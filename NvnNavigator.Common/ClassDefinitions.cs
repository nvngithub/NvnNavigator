using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Threading;
using System.Xml.Serialization;
using System.Drawing.Drawing2D;
using System.Xml;
using System.Reflection;
using System.Configuration;
using System.ComponentModel;
using System.Security.Cryptography;

namespace NvnNavigator.Common {

    [Serializable]
    public class NavigatorPoint {
        private string id = Globals.GetUniqueId();
        /****** Images taken in anti-clickwise direction ******/
        private string img1; // straight image
        private string img2; // left image
        private string img3; // backside image
        private string img4; // right image
        private int nextPointAngle = 0;

        private List<JunctionPoint> junctionPoints = new List<JunctionPoint>();

        public string Id {
            get { return id; }
            set { id = value; }
        }

        public string Img1 {
            get { return img1; }
            set { img1 = value; }
        }

        public string Img2 {
            get { return img2; }
            set { img2 = value; }
        }

        public string Img3 {
            get { return img3; }
            set { img3 = value; }
        }

        public string Img4 {
            get { return img4; }
            set { img4 = value; }
        }

        public int NextPointAngle {
            get { return nextPointAngle; }
            set { nextPointAngle = value; }
        }

        public List<JunctionPoint> JunctionPoints {
            get { return junctionPoints; }
        }

        public override string ToString() {
            return id;
        }
    }

    [Serializable]
    public class JunctionPoint {
        private int pathAngle;
        private NavigatorPath path;
        private StartOrEnd startOrEnd;

        public int PathAngle {
            get { return pathAngle; }
            set { pathAngle = value; }
        }

        public NavigatorPath Path {
            get { return path; }
            set { path = value; }
        }

        public StartOrEnd StartOrEnd {
            get { return startOrEnd; }
            set { startOrEnd = value; }
        }
    }

    [Serializable]
    public class NavigatorLocation {
        private readonly string id = Guid.NewGuid().ToString();
        private List<NavigatorPoint> points = new List<NavigatorPoint>();

        public string Id {
            get { return id; }
        }

        public List<NavigatorPoint> Points {
            get { return points; }
        }
    }

    [Serializable]
    public class NavigatorPath {
        private string id = Guid.NewGuid().ToString();
        private List<NavigatorPoint> points = new List<NavigatorPoint>(); // Double linked list

        public string Id {
            get { return id; }
            set { id = value; }
        }

        public List<NavigatorPoint> Points {
            get { return points; }
        }

        public override string ToString() {
            return id;
        }
    }

    [Serializable]
    public class NavigatorPlace {
        private List<NavigatorPath> paths = new List<NavigatorPath>();
        private List<NavigatorLocation> locations = new List<NavigatorLocation>();

        public List<NavigatorPath> Paths {
            get { return paths; }
        }

        public List<NavigatorLocation> Locations {
            get { return locations; }
        }

        public NavigatorPath GetPath(string id) {
            foreach (NavigatorPath path in paths) {
                if (path.Id == id) {
                    return path;
                }
            }

            return null;
        }

        private static NavigatorPlace place;
        public static NavigatorPlace Place {
            get { return place; }
            set { place = value; }
        }
    }

    public class NavigatorSearch {
        public static List<string> Search(NavigatorPath currentPath, NavigatorPoint endpoint) {
            List<string> pathIds = SearchHotspot(currentPath, endpoint);

            string selectedPathIds = string.Empty;
            foreach (string pathIdList in pathIds) {
                if (pathIdList.Contains("@")) {
                    selectedPathIds = pathIdList;
                    break;
                }
            }

            return new List<string>();
        }

        private static List<string> SearchHotspot(NavigatorPath path, NavigatorPoint endpoint) {
            List<string> idsList = new List<string>();

            bool endpointExists = false;
            List<JunctionPoint> junctionPoints = path.Points[path.Points.Count - 1].JunctionPoints;
            if (junctionPoints != null) {
                foreach (JunctionPoint junctionPoint in junctionPoints) {
                    if (junctionPoint.Path.Points.Contains(endpoint)) {

                        break;
                    } else {
                        List<string> pathIds = SearchHotspot(junctionPoint.Path, endpoint);
                        foreach (string paths in pathIds) {
                            idsList.Add(path.Id + "#" + paths);
                        }
                    }
                }
            }

            // if it is last node
            if (idsList.Count == 0) {
                idsList.Add(path.Id + (endpointExists ? "@" : "")); // current path id
            }
            
            return idsList;
        }
    }

    [Serializable]
    public class MapPoint {
        private int x;
        private int y;

        [XmlAttribute]
        public int X {
            get { return x; }
            set { x = value; }
        }

        [XmlAttribute]
        public int Y {
            get { return y; }
            set { y = value; }
        }
    }

    [Serializable]
    public class MapPath {
        private string id;
        private List<MapPoint> points = new List<MapPoint>();

        [XmlAttribute]
        public string Id {
            get { return id; }
            set { id = value; }
        }

        [XmlArrayItem(ElementName = "p")]
        public List<MapPoint> Points {
            get { return points; }
            set { points = value; }
        }
    }

    [Serializable]
    public class Map {
        private string name;
        private string floor;
        private List<string> pathIds = new List<string>();

        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Floor {
            get { return this.floor; }
            set { this.floor = value; }
        }

        public List<string> PathIds {
            get {
                if (pathIds == null) pathIds = new List<string>();
                return pathIds;
            }
            set { pathIds = value; }
        }

        public override string ToString() {
            return name;
        }

    }

    [Serializable]
    public class LogoSettings {
        private static LogoSettings instance;
        private static string logoSettingsPath = Globals.SettingsDir + "logo.xml";

        private string filename;
        private bool enabled = true;
        private Size size = new Size(243, 64);

        public string FileName {
            get { return filename; }
            set { filename = value; }
        }

        public bool Enabled {
            get { return enabled; }
            set { enabled = value; }
        }

        public Size Size {
            get { return size; }
            set { size = value; }
        }

        public static LogoSettings Instance {
            get {
                if (instance == null) instance = new LogoSettings();
                return instance;
            }
        }

        public static void Save() {
            LoadSave.Save(logoSettingsPath, instance, typeof(LogoSettings));
        }

        public static void Load() {
            instance = (LogoSettings)LoadSave.Load(logoSettingsPath, typeof(LogoSettings));

        }
    }

    [Serializable]
    public class AdSettings {
        private string filename;
        private int displayInterval;
        private FadeType fadeType;
        private bool enabled;

        public string FileName {
            get { return filename; }
            set { filename = value; }
        }

        public int DisplayInterval {
            get { return displayInterval; }
            set { displayInterval = value; }
        }

        public FadeType FadeType {
            get { return fadeType; }
            set { fadeType = value; }
        }

        public bool Enabled {
            get { return enabled; }
            set { enabled = value; }
        }
    }

    public class AdSettingsContainer {
        public static List<AdSettings> Ads = new List<AdSettings>();
        public static bool IsLoaded = false;
        private static string adsFileName = Globals.SettingsDir + "ads.xml";

        public static void Save() {
            LoadSave.Save(adsFileName, Ads, typeof(List<AdSettings>));
        }

        public static void Load() {
            Ads.Clear();
            List<AdSettings> ads = (List<AdSettings>)LoadSave.Load(adsFileName, typeof(List<AdSettings>));
            if (ads != null) {
                Ads.AddRange(ads.ToArray());
            }
            IsLoaded = true;
        }
    }

    [Serializable]
    public class Shop {
        private string id;
        private string name;
        private string category;
        private string number;
        private string floor;
        private string iconName;
        private string tagline;
        private string description;

        public string Id {
            get { return id; }
            set { id = value; }
        }

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string Category {
            get { return category; }
            set { category = value; }
        }

        public string Number {
            get { return number; }
            set { number = value; }
        }

        public string Floor {
            get { return floor; }
            set { floor = value; }
        }

        public string IconName {
            get { return iconName; }
            set { iconName = value; }
        }

        public string Tagline {
            get { return tagline; }
            set { tagline = value; }
        }

        public string Description {
            get { return description; }
            set { description = value; }
        }
    }

    public class ShopManager {
        public static List<Shop> Shops = new List<Shop>();
        private static string shopFileName = Globals.SettingsDir + "shops.xml";

        public static void Save() {
            LoadSave.Save(shopFileName, Shops, typeof(List<Shop>));
        }

        public static void Load() {
            Shops.Clear();
            List<Shop> shops = (List<Shop>)LoadSave.Load(shopFileName, typeof(List<Shop>));
            if (shops != null) {
                Shops.AddRange(shops.ToArray());
            }
        }
    }

    public class GroupBase {
        protected static string groupFileName = string.Empty;
        public List<string> Items = new List<string>();

        public void Save() {
            LoadSave.Save(groupFileName, Items, typeof(List<string>));
        }

        public void Load() {
            Items.Clear();
            List<string> items = (List<string>)LoadSave.Load(groupFileName, typeof(List<string>));
            if (items != null) {
                Items.AddRange(items.ToArray());
            }
        }
    }

    public class Categories : GroupBase {
        public Categories() {
            groupFileName = Globals.SettingsDir + "categories.xml";
        }
    }

    public class Floors : GroupBase {
        public Floors() {
            groupFileName = Globals.SettingsDir + "floors.xml";
        }
    }

    public class GroupManager {
        private static Floors floors;
        private static Categories categories;

        public static Floors Floors {
            get {
                if (floors == null) floors = new Floors();
                return floors;
            }
        }

        public static Categories Categories {
            get {
                if (categories == null) categories = new Categories();
                return categories;
            }
        }
    }

    [Serializable]
    public class GroupSettings {
        private string groupName;
        private GroupType groupType;
        private Color groupNameColor;
        private Color groupNameBackgroundColor;
        private Font groupNameFont;
        private Color shopNameColor;
        private Font shopNameFont;
        private Color shopDescriptionColor;
        private Font shopDescriptionFont;
        private Color shopBackgroundColor;
        private Size logoSize;
        private Size shopControlSize;

        private TypeConverter sizeConverter = TypeDescriptor.GetConverter(typeof(Size));
        private TypeConverter fontConverter = TypeDescriptor.GetConverter(typeof(Font));
        private TypeConverter colorConverter = TypeDescriptor.GetConverter(typeof(Color));

        public string GroupName {
            get { return groupName; }
            set { groupName = value; }
        }

        public GroupType GroupType {
            get { return groupType; }
            set { groupType = value; }
        }

        [XmlIgnore]
        public Color GroupNameColor {
            get { return groupNameColor; }
            set { groupNameColor = value; }
        }

        public string SerializableGroupNameColor {
            get { return colorConverter.ConvertToInvariantString(groupNameColor); }
            set { groupNameColor = (Color)colorConverter.ConvertFromString(value); }
        }

        [XmlIgnore]
        public Color GroupNameBackgroundColor {
            get { return groupNameBackgroundColor; }
            set { groupNameBackgroundColor = value; }
        }

        public string SerializableGroupNameBackgroundColor {
            get { return colorConverter.ConvertToInvariantString(groupNameBackgroundColor); }
            set { groupNameBackgroundColor = (Color)colorConverter.ConvertFromString(value); }
        }

        [XmlIgnore]
        public Font GroupNameFont {
            get { return groupNameFont; }
            set { groupNameFont = value; }
        }

        public string SerializableGroupNameFont {
            get { return fontConverter.ConvertToInvariantString(groupNameFont); }
            set { groupNameFont = (Font)fontConverter.ConvertFromString(value); }
        }

        [XmlIgnore]
        public Color ShopNameColor {
            get { return shopNameColor; }
            set { shopNameColor = value; }
        }

        public string SerializableShopNameColor {
            get { return colorConverter.ConvertToInvariantString(shopNameColor); }
            set { shopNameColor = (Color)colorConverter.ConvertFromString(value); }
        }

        [XmlIgnore]
        public Font ShopNameFont {
            get { return shopNameFont; }
            set { shopNameFont = value; }
        }

        public string SerializableShopNameFont {
            get { return fontConverter.ConvertToInvariantString(shopNameFont); }
            set { shopNameFont = (Font)fontConverter.ConvertFromString(value); }
        }

        [XmlIgnore]
        public Color ShopDescriptionColor {
            get { return shopDescriptionColor; }
            set { shopDescriptionColor = value; }
        }

        public string SerializableShopDescriptionColor {
            get { return colorConverter.ConvertToInvariantString(shopDescriptionColor); }
            set { shopDescriptionColor = (Color)colorConverter.ConvertFromString(value); }
        }

        [XmlIgnore]
        public Font ShopDescriptionFont {
            get { return shopDescriptionFont; }
            set { shopDescriptionFont = value; }
        }

        public string SerializableShopDescriptionFont {
            get { return fontConverter.ConvertToInvariantString(shopDescriptionFont); }
            set { shopDescriptionFont = (Font)fontConverter.ConvertFromString(value); }
        }

        [XmlIgnore]
        public Color ShopBackgroundColor {
            get { return shopBackgroundColor; }
            set { shopBackgroundColor = value; }
        }

        public string SerializableShopBackgroundColor {
            get { return colorConverter.ConvertToInvariantString(shopBackgroundColor); }
            set { shopBackgroundColor = (Color)colorConverter.ConvertFromString(value); }
        }

        [XmlIgnore]
        public Size LogoSize {
            get { return logoSize; }
            set { logoSize = value; }
        }

        public string SerializableLogoSize {
            get { return sizeConverter.ConvertToInvariantString(logoSize); }
            set { logoSize = (Size)sizeConverter.ConvertFromString(value); }
        }

        [XmlIgnore]
        public Size ShopControlSize {
            get { return shopControlSize; }
            set { shopControlSize = value; }
        }

        public string SerializableShopControlSize {
            get { return sizeConverter.ConvertToInvariantString(shopControlSize); }
            set { shopControlSize = (Size)sizeConverter.ConvertFromString(value); }
        }

        public void Copy(GroupSettings settings) {
            this.GroupNameBackgroundColor = settings.GroupNameBackgroundColor;
            this.GroupNameColor = settings.GroupNameColor;
            this.GroupNameFont = settings.GroupNameFont;
            this.LogoSize = settings.LogoSize;
            this.ShopBackgroundColor = settings.ShopBackgroundColor;
            this.ShopControlSize = settings.ShopControlSize;
            this.ShopDescriptionColor = settings.ShopDescriptionColor;
            this.ShopDescriptionFont = settings.ShopDescriptionFont;
            this.ShopNameColor = settings.ShopNameColor;
            this.ShopNameFont = settings.ShopNameFont;
        }
    }

    public class DefaultGroupSettings {
        private static string groupSettingsFileName = Globals.LocalFolder + "DefaultGroupSettings.xml";
        private static GroupSettings groupSettings;

        public static GroupSettings Instance {
            get {
                if (groupSettings == null) {
                    // copy files to common folder if not found
                    if (File.Exists(groupSettingsFileName) == false) {
                        IOSupport.CreateDirectory(Path.GetDirectoryName(groupSettingsFileName));
                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml(Properties.Resources.DefaultGroupSettings);
                        doc.Save(groupSettingsFileName);
                    }

                    Load();
                }
                return groupSettings;
            }
            set {
                groupSettings = value;
            }
        }

        public static void Load() {
            groupSettings = (GroupSettings)LoadSave.Load(groupSettingsFileName, typeof(GroupSettings));
        }

        public static void Save() {
            LoadSave.Save(groupSettingsFileName, groupSettings, typeof(GroupSettings));
        }
    }

    public class GroupSettingsManager {
        public static List<GroupSettings> Groups = new List<GroupSettings>();
        private static string groupSettingsFileName = Globals.SettingsDir + "groups.xml";

        public static void Save() {
            // assign default settings to each group if not in the list
            foreach (string groupName in GroupManager.Floors.Items) {
                if (GroupExists(groupName) == false) {
                    GroupSettings newGroupSettings = new GroupSettings();
                    newGroupSettings.GroupName = groupName;
                    newGroupSettings.GroupType = GroupType.Floor;
                }
            }

            // delete if there is any extra group (may be deleted by the user)

            LoadSave.Save(groupSettingsFileName, Groups, typeof(List<Shop>));
        }

        private static bool GroupExists(string groupName) {
            bool exists = false;
            foreach (GroupSettings groupSettings in Groups) {
                if (groupSettings.GroupName == groupName) {
                    exists = true;
                    break;
                }
            }
            return exists;
        }

        public static void Load() {
            Groups.Clear();
            List<GroupSettings> groups = (List<GroupSettings>)LoadSave.Load(groupSettingsFileName, typeof(List<GroupSettings>));
            if (groups != null) {
                Groups.AddRange(groups.ToArray());
            }
        }

        public static GroupSettings GetGroupSettings(string groupName) {
            foreach (GroupSettings settings in Groups) {
                if (settings.GroupName == groupName) {
                    return settings;
                }
            }

            return DefaultGroupSettings.Instance;
        }
    }

    [Serializable]
    public class Hotspot {
        private string imageName;
        private List<HotspotLocation> locations = new List<HotspotLocation>();

        public string ImageName {
            get { return imageName; }
            set { imageName = value; }
        }

        public List<HotspotLocation> Locations {
            get { return locations; }
            set { locations = value; }
        }
    }

    [Serializable]
    public class HotspotLocation {
        private string imageName;
        private string navigatorPathId;

        public string NavigatorPathId {
            get { return navigatorPathId; }
            set { navigatorPathId = value; }
        }

        public string ImageName {
            get { return imageName; }
            set { imageName = value; }
        }

        public NavigatorPoint GetNavigatorPoint() {
            return null;
        }
    }

    [Serializable]
    public class HotspotManager {
        private static List<Hotspot> hotspots = new List<Hotspot>();
        private static string hotspotsFileName = Globals.SettingsDir + "hotspots.xml";

        public static List<Hotspot> Hotspots {
            get { return hotspots; }
            set { hotspots = value; }
        }

        public static void Save() {
            LoadSave.Save(hotspotsFileName, hotspots, typeof(List<Hotspot>));
        }

        public static void Load() {
            hotspots.Clear();
            List<Hotspot> spots = (List<Hotspot>)LoadSave.Load(hotspotsFileName, typeof(List<Hotspot>));
            if (spots != null) {
                hotspots.AddRange(spots.ToArray());
            }
        }
    }

    [Serializable]
    public class YouAreHereLocation {
        private string pathId;
        private NavigatorPoint point;
        private int angle;
        private static YouAreHereLocation instance;
        private string youarehereLocationFile = Globals.SettingsDir + "youarehere.xml";

        private YouAreHereLocation() { }

        public string PathId {
            get { return pathId; }
            set { pathId = value; }
        }

        public NavigatorPoint Point {
            get { return point; }
            set { point = value; }
        }

        public int Angle {
            get { return angle; }
            set { angle = value; }
        }

        public static YouAreHereLocation Instance {
            get {
                if (instance == null) instance = new YouAreHereLocation();
                return instance;
            }
        }

        public void Save() {
            LoadSave.Save(youarehereLocationFile, instance, typeof(YouAreHereLocation));
        }

        public void Load() {
            instance = (YouAreHereLocation)LoadSave.Load(youarehereLocationFile, typeof(YouAreHereLocation));
        }
    }

    [Serializable]
    public class LayoutSettings {
        private ViewMapLayout viewMapLayout = ViewMapLayout.ViewLeftMapRight;
        private AdLayout adLayout = AdLayout.Bottom;
        private bool enabled = true;
        private static LayoutSettings instance;
        private static string layoutSettingsFile = Globals.SettingsDir + "layoutsettings.xml";

        private LayoutSettings() { }

        public ViewMapLayout ViewMapLayout {
            get { return viewMapLayout; }
            set { viewMapLayout = value; }
        }

        public AdLayout AdLayout {
            get { return adLayout; }
            set { adLayout = value; }
        }

        public bool Enabled {
            get { return enabled; }
            set { enabled = value; }
        }

        public static LayoutSettings Instance {
            get {
                if (instance == null) instance = new LayoutSettings();
                return instance;
            }
        }

        public void Save() {
            LoadSave.Save(layoutSettingsFile, instance, typeof(LayoutSettings));
        }

        public void Load() {
            instance = (LayoutSettings)LoadSave.Load(layoutSettingsFile, typeof(LayoutSettings));
        }
    }

    public class Globals {
        public static float LineThinkness = 2F;
        public static float NavigatorPointThickness = 5F;

        public static string ApplicationDisplayName = "Nvn Navigator";

        private static string ApplicationName = "NvnNavigator";
        public static string LocalFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + ApplicationName + "\\";
        public static string RemoteProjectFile = string.Empty;

        public static string AppLocation = Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase.ToString()).LocalPath);
        public static string AppImagesLocation = AppLocation + @"\img\";

        public static string ProjectDir = string.Empty;
        public static NavigatorPlace NavigatorPlace; //TODO: DONT USE THIS

        public static string ProjectFile {
            get { return ProjectDir + "\\Navigator.prj"; }
        }

        public static string ImagesDir {
            get { return ProjectDir + @"\Images\"; }
        }

        public static string SettingsDir {
            get { return ProjectDir + @"\Settings\"; }
        }

        public static string SettingsResourceDir {
            get { return SettingsDir + @"Resources\"; }
        }

        public static string MapsDir {
            get { return ProjectDir + @"\maps\"; }
        }

        public static string MapPathsDir {
            get { return ProjectDir + @"\maps\paths\"; }
        }

        public static string MapsFile {
            get { return MapsDir + "maps.xml"; }
        }

        public static string GetUniqueId() {
            return Guid.NewGuid().ToString().Replace("-", "");
        }

        public static bool IsDebugMode = true;
    }
    
    [Serializable]
    public class User {
        private string adminPassword = "admin";
        private string clientPassword = "client";

        private static User instance;
        private static string userFile = Globals.LocalFolder + "users.xml";

        private User() { }

        public static string AdminPassword {
            get {
                Load();
                return instance.adminPassword;
            }
            set {
                Save();
                instance.adminPassword = value;
            }
        }

        public static string ClientPassword {
            get {
                Load();
                return instance.clientPassword;
            }
            set {
                Save();
                instance.clientPassword = value;
            }
        }

        public string AdminPasswordEncrypted {
            get { return EncryptionHelper.Encrypt(adminPassword); }
            set { adminPassword = value; }
        }

        public string ClientPasswordEncrypted {
            get { return EncryptionHelper.Encrypt(clientPassword); }
            set { clientPassword = value; }
        }

        public static void Save() {
            LoadSave.Save(userFile, instance, typeof(User));
        }

        public static void Load() {
            instance = (User)LoadSave.Load(userFile, typeof(User));
            if (instance == null) {
                instance = new User();
                Save(); // Save default passwords
            } else {
                instance.adminPassword = EncryptionHelper.Decrypt(instance.adminPassword);
                instance.clientPassword = EncryptionHelper.Decrypt(instance.clientPassword);
            }
        }
    }

    public class IOSupport {
        public static bool IsRemoteFile(string filename) {
            #region good one
            //IPAddress[] host;
            //IPAddress[] local;
            //bool isLocal = false;

            //Uri uri = new Uri(filename);
            //host = Dns.GetHostAddresses(uri.Host);
            //local = Dns.GetHostAddresses(Dns.GetHostName());
            //foreach (IPAddress hostAddress in host)
            //{
            //    if (IPAddress.IsLoopback(hostAddress))
            //    {
            //        isLocal = true;
            //        break;
            //    }
            //    else
            //    {
            //        foreach (IPAddress localAddress in local)
            //        {
            //            if (hostAddress.Equals(localAddress))
            //            {
            //                isLocal = true; break;
            //            }
            //        }
            //        if (isLocal)
            //        {
            //            break;
            //        }
            //    }
            //}

            //return isLocal;
            #endregion

            return filename.StartsWith(@"\\");
        }

        public static void CreateDirectory(string path) {
            if (Directory.Exists(path) == false) {
                Directory.CreateDirectory(path);
            }
        }

        public static void CopyFile(string sourceFile, string destFile) {
            CopyFile(sourceFile, destFile, true);
        }

        public static void CopyFile(string sourceFile, string destFile, bool overwrite) {
            string destDir = Path.GetDirectoryName(destFile);
            if (Directory.Exists(destDir) == false) {
                Directory.CreateDirectory(destDir);
            }

            File.Copy(sourceFile, destFile, overwrite);
        }

        public static void RenameFile(string sourceFile, string destFile) {
            if ((new FileInfo(sourceFile)).FullName == (new FileInfo(destFile)).FullName) return;

            RenameFile(sourceFile, destFile, true);
        }

        public static void RenameFile(string sourceFile, string destFile, bool overwrite) {
            if (File.Exists(sourceFile)) {
                if (File.Exists(destFile)) {
                    if (overwrite) {
                        File.Delete(destFile);
                        File.Move(sourceFile, destFile);
                    }
                } else {
                    File.Move(sourceFile, destFile);
                }
            }
        }

        public static void DeleteFile(string filename) {
            if (File.Exists(filename)) {
                File.Delete(filename);
            }
        }

        public static void DeleteDirectory(string dirPath, bool recursive) {
            if (Directory.Exists(dirPath)) {
                Directory.Delete(dirPath, recursive);
            }
        }

        public static void CreateParentDirectory(string filename) {
            string directory = Path.GetDirectoryName(filename);
            if (Directory.Exists(directory) == false) {
                Directory.CreateDirectory(directory);
            }
        }
    }

    public class Logger {
        public static event EventHandler MessageLogged;

        public static void WriteLog(string message) {
            if(MessageLogged != null){
                MessageLogged(message, null);
            }
        }
    }

    public class LoadSave {
        public static NavigatorPlace Load(string filename) {
            NavigatorPlace place = null;
            using (Stream fileStream = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) {
                BinaryFormatter bf = new BinaryFormatter();
                place = (NavigatorPlace)bf.Deserialize(fileStream);
            }
            return place;
        }

        public static void Save(string filename, Object o) {
            Stream file = File.Open(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(file, o);
            file.Close();
        }

        public static void SaveMapPath(MapPath path, string filename) {
            using (StreamWriter w = new StreamWriter(filename)) {
                XmlSerializer s = new XmlSerializer(typeof(MapPath));
                s.Serialize(w, path);
            }
        }

        public static MapPath LoadMapPath(string filename) {
            MapPath path = null;
            if (File.Exists(filename)) {
                using (StreamReader sr = new StreamReader(filename)) {
                    using (XmlTextReader xr = new XmlTextReader(sr)) {
                        XmlSerializer xs = new XmlSerializer(typeof(MapPath));
                        if (xs.CanDeserialize(xr)) {
                            path = (MapPath)xs.Deserialize(xr);
                        }
                    }
                }
            }

            return path;
        }

        public static void SaveMaps(List<Map> maps, string projectFile) {
            using (Stream w = (Stream)File.Open(Globals.MapsFile, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite)) {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize((Stream)w, maps);
            }
        }

        public static List<Map> LoadMaps(string projectFile) {
            List<Map> maps = null;
            if (String.IsNullOrEmpty(projectFile) == false) {
                if (File.Exists(Globals.MapsFile)) {
                    using (Stream stream = File.Open(Globals.MapsFile, FileMode.Open)) {
                        BinaryFormatter bin = new BinaryFormatter();
                        maps = (List<Map>)bin.Deserialize(stream);
                    }
                }
            }

            return maps;
        }

        public static void Save(string filename, object o, Type type) {
            IOSupport.CreateParentDirectory(filename);
            using (StreamWriter w = new StreamWriter(filename)) {
                XmlSerializer s = new XmlSerializer(type);
                s.Serialize(w, o);
            }
        }

        public static object Load(string filename, Type type) {
            if (File.Exists(filename)) {
                using (StreamReader sr = new StreamReader(filename)) {
                    using (XmlTextReader xr = new XmlTextReader(sr)) {
                        XmlSerializer xs = new XmlSerializer(type);
                        if (xs.CanDeserialize(xr)) {
                            return xs.Deserialize(xr);
                        }
                    }
                }
            }

            return null;
        }
    }

    public class RecentFiles {
        private static List<string> files = new List<string>();
        private static string recentFilesFile = Globals.LocalFolder + "\\" + "recentfiles.xml";

        public static List<string> Files {
            get { return files; }
            set { files = value; }
        }

        public static void Save() {
            LoadSave.Save(recentFilesFile, files, typeof(List<string>));
        }

        public static void Load() {
            files.Clear();
            List<string> recentfiles = (List<string>)LoadSave.Load(recentFilesFile, typeof(List<string>));
            if (recentfiles != null) {
                files.AddRange(recentfiles.ToArray());
            }
        }
    }

    public class ImageLoader {
        public static Image GetImageFromFile(string filepath, int width, int height) {
            Bitmap image = null;
            if (File.Exists(filepath)) {
                using (Stream stream = (Stream)File.Open(filepath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)) {
                    image = new Bitmap(width, height, PixelFormat.Format32bppPArgb);
                    using (Graphics g = Graphics.FromImage((Image)image)) {
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        g.DrawImage(Image.FromStream(stream), 0, 0, image.Width, image.Height);
                    }
                }
            }
            return image;
        }

        public static Image GetImageFromFile(string filepath) {
            Image image = null;
            if (File.Exists(filepath)) {
                using (Stream stream = (Stream)File.Open(filepath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)) {
                    image = Image.FromStream(stream);
                }
            }
            return image;
        }
    }

    public class FadeImage {
        private Brush fillBrush = new SolidBrush(Color.White);
        private int fadeCount = 5;
        private PictureBox pictureBox;

        public PictureBox PictureBox {
            get { return pictureBox; }
            set { pictureBox = value; }
        }

        public void SplitRightToLeft() {
            if (pictureBox.Image == null) return;
            for (int fadeindex = 0; fadeindex < pictureBox.Width / fadeCount; fadeindex++) {
                Graphics g = Graphics.FromImage(pictureBox.Image);
                int distance = pictureBox.Width / fadeCount;
                for (int y = 0; y < pictureBox.Height; y++) {
                    for (int x = 0; x < pictureBox.Width; x = x + distance) {
                        g.FillRectangle(fillBrush, new Rectangle(x + fadeindex, y, 1, 1));
                    }
                }

                pictureBox.Refresh();
            }
        }

        // Left to right
        public void FadeLeftToRight() {
            if (pictureBox.Image == null) return;
            Graphics g = Graphics.FromImage(pictureBox.Image);
            for (int x = 0; x < pictureBox.Width; x++) {
                for (int y = 0; y < pictureBox.Height; y++) {
                    g.FillRectangle(fillBrush, new Rectangle(x, y, 1, 1));
                }
                pictureBox.Refresh();
            }
        }

        // right to left
        public void FadeRightToLeft() {
            if (pictureBox.Image == null) return;
            Graphics g = Graphics.FromImage(pictureBox.Image);
            for (int x = pictureBox.Width - 1; x >= 0; x--) {
                for (int y = 0; y < pictureBox.Height; y++) {
                    g.FillRectangle(fillBrush, new Rectangle(x, y, 1, 1));
                }
                pictureBox.Refresh();
            }
        }

        // top to bottom
        public void FadeTopToBottom() {
            if (pictureBox.Image == null) return;
            Graphics g = Graphics.FromImage(pictureBox.Image);
            for (int y = 0; y < pictureBox.Height; y++) {
                for (int x = 0; x < pictureBox.Width; x++) {
                    g.FillRectangle(fillBrush, new Rectangle(x, y, 1, 1));
                }
                pictureBox.Refresh();
            }
        }

        // bottom to top
        public void FadeBottomToTop() {
            if (pictureBox.Image == null) return;
            Graphics g = Graphics.FromImage(pictureBox.Image);
            for (int y = pictureBox.Height - 1; y >= 0; y--) {
                for (int x = 0; x < pictureBox.Width; x++) {
                    g.FillRectangle(fillBrush, new Rectangle(x, y, 1, 1));
                }
                pictureBox.Refresh();
            }
        }

        public void DarkenImage() {
            if (pictureBox.Image == null) return;
            for (int i = 50; i > 0; i--) {
                pictureBox.Image = AlterBrightness(pictureBox.Image, i);
                pictureBox.Refresh();
                Thread.Sleep(50);
            }
        }

        public void BrightenImage() {
            if (pictureBox.Image == null) return;
            for (int i = 50; i < 100; i++) {
                pictureBox.Image = AlterBrightness(pictureBox.Image, i);
                pictureBox.Refresh();
                Thread.Sleep(50);
            }
        }

        private static Image AlterBrightness(System.Drawing.Image bmp, int level) {
            Graphics graphics = Graphics.FromImage(bmp);
            if (level == 50) {
                // do nothing
                return bmp;
            } else if (level < 50) {
                // make it darker
                // Work out how much darker
                int conversion = 250 - (5 * level);
                Pen pDark = new Pen(Color.FromArgb(conversion, 0, 0, 0), bmp.Width * 2);
                graphics.DrawLine(pDark, 0, 0, bmp.Width, bmp.Height);
            } else if (level > 50) {
                // mark it lighter
                // Work out how much lighter.
                int conversion = (5 * (level - 50));
                Pen pLight = new Pen(Color.FromArgb(conversion, 255, 255, 255), bmp.Width * 2);
                graphics.DrawLine(pLight, 0, 0, bmp.Width, bmp.Height);
            }
            //graphics.Save();
            //graphics.Dispose();
            return bmp;
        }
    }

    public class PropertyInvoker {
        private PropertyInfo propInfo;
        private object obj;

        public PropertyInvoker(string PropertyName, object o) {
            obj = o;
            propInfo = o.GetType().GetProperty(PropertyName);
        }

        public object Property {
            get {
                return propInfo.GetValue(obj, null);
            }
            set {
                propInfo.SetValue(obj, value, null);
            }
        }
    }

    public static class EncryptionHelper {
        private const string cryptoKey = "A5BF7F78-59D6-4d51-A14B-A7B49C53E078";

        // The Initialization Vector for the DES encryption routine
        private static readonly byte[] IV = new byte[8] { 240, 3, 45, 29, 0, 76, 173, 59 };

        public static string Encrypt(string s) {
            if (String.IsNullOrEmpty(s)) return string.Empty;

            string result = string.Empty;
            byte[] buffer = Encoding.ASCII.GetBytes(s);

            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();
            des.Key = MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(cryptoKey));
            des.IV = IV;
            result = Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length));

            return result;
        }

        public static string Decrypt(string s) {
            if (s == null || s.Length == 0) return string.Empty;

            string result = string.Empty;
            byte[] buffer = Convert.FromBase64String(s);

            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();
            des.Key = MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(cryptoKey));
            des.IV = IV;
            result = Encoding.ASCII.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length));

            return result;
        }
    }

    public class ActiveChangedEventArgs : EventArgs {
        private bool active;

        public bool Active {
            get { return active; }
            set { active = value; }
        }

        public ActiveChangedEventArgs(bool active) {
            this.active = active;
        }
    }

    public class NavigatorPositionChangedEventArgs : EventArgs {
        private NavigatorPoint point;
        private NavigatorPath path;

        public NavigatorPoint Point {
            get { return point; }
        }

        public NavigatorPath Path {
            get { return path; }
        }

        public NavigatorPositionChangedEventArgs(NavigatorPoint point, NavigatorPath path) {
            this.point = point;
            this.path = path;
        }
    }

    public class HotspotClickedEventArgs : EventArgs {
        private HotspotLocation location;

        public HotspotLocation Location {
            get { return location; }
        }

        public HotspotClickedEventArgs(HotspotLocation location) {
            this.location = location;
        }
    }
}