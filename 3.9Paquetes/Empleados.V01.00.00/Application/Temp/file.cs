
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Private.CoreLib;
using System.Threading.Tasks;
using FluentValidation;

using WooW.Model;

using ServiceStack;

using WooW.DTO;


 

using Microsoft.JSInterop;

namespace UnitTest_proj {

public class Program
{
    public static void Main(string[] args)
    {
        EmpleadoScriptsUser su = new EmpleadoScriptsUser();
        su.MainMethod();
    }
}

public partial class EmpleadoScriptsUser{ public  Action? StateHasChangeEvt { get; set; }
public  string Transicion { get; set; } = "Navegacion";
public  JsonApiClient woTarget { get; set; }
public  IJSRuntime JS { get; set; }
public  EmpleadoControls EmpleadoControles { get; set; }
public Empleado Empleado = new Empleado();
 public void MainMethod(){} }
public partial class EmpleadoValidator : AbstractValidator<Empleado>
{
    public  Action? StateHasChangeEvt { get; set; }
public  string Transicion { get; set; } = "Navegacion";
public  JsonApiClient woTarget { get; set; }
public  IJSRuntime JS { get; set; }
public  EmpleadoControls EmpleadoControles { get; set; }
public Empleado Empleado = new Empleado();


    public EmpleadoValidator()
    {
 RuleFor(x => x.Salario).GreaterThan(0).WithMessage("El salario debe ser mayor a 0."); 

} }

    #region Layout

	public enum eScreenSize
	{
		XSmall,
		Small,
		Medium,
		Large,
		XLarge
	}

    #endregion Layout

    #region Toolbar

    public enum eToolbarItemAlignment
	{
		Left,
		Right
	}

    #endregion Toolbar

    #region Common Containers Items

    public enum eContainerItemColor
	{
		Default,
		Primary,
		Secondary,
		Success,
		Danger,
		Warning,
		Info,
		Light,
		Dark,
		BorderPrimary,
		BorderSecondary,
		BorderSuccess,
		BorderDanger,
		BorderWarning,
		BorderInfo,
		BorderLight,
		BorderDark

	}

	#endregion Common Containers Items

	#region Group

	public enum eGroupColor
	{
		Default,
		Background,
		Primary,
		Secondary,
		Success,
		Danger,
		Warning,
		Info,
		Light,
		Dark
	}

	public enum eGroupDecoration
	{
		None,
		Card
	}

	#endregion Group

	#region Item

	public enum eItemEnabled
	{
		Activo,
		Inactivo
	}

	public enum eItemSize
	{
		Large,
		Normal,
		Small
	}

    #endregion Item

    #region LookupInputwidth

	public enum eLookupInputWidth
	{
		small,
		medium,
		large,
		full
	}

    #endregion LookupInputwidth

    #region GridSummaryType

	public enum eGridSummaryType
	{
		Sum,
		Min,
		Max,
		Count,
		Avg,
		//Custom,
		None,
	}

    #endregion GridSummaryType

    #region Unbound Grid Columns

	public enum eGridUnboundColumnType
	{
		Boolean,
		Bound,
		DateTime,
		Decimal,
		Integer,
		Object,
		String,
		//Custom
	}

    #endregion Unbound Grid Columns

    #region Button

    public enum eButtonSize
	{
		Grande,
		Normal,
		Pequeño
	}

	public enum eButtonColor
	{
		Default,
		Primary,
		Secondary,
		Success,
		Danger,
		Warning,
		Info,
		Light,
		Dark,
		Link,
		OutlinePrimary,
		OutlineSecondary,
		OutlineSuccess,
		OutlineInfo,
		OutlineWarning,
		OutlineDanger,
		OutlineLight,
		OutlineDark
	}

	#endregion Button

	#region Text

	public enum eTextColor
	{
		FontDefault,
		Primary,
		Secondary,
		Warning,
		Danger,
		Success,
		Info,
		Muted,
		Light,
		Dark,
		Black,
		White
	}

	public enum eTextSize
	{
		Large,
		Normal,
		Small
	}

	public enum eTextWeight
	{
		Light,
		Normal,
		Bold
	}

	public enum eTextItalic
	{
		None,
		Italic
	}

	public enum eTextDecoration
	{
		None,
		Underline,
		Through
	}

	#endregion Text

	#region Table

	public enum eTableDesign
	{
		None,
		Hover
	}

	public enum eTableRowColor
	{
		Default,
		Active,
		Primary,
		Secondary,
		Success,
		Danger,
		Warning,
		Info,
		Light,
		Dark
	}

    #endregion Table

    #region CheckBoxStyle

    public enum eCheckBoxStyle
    {
        Checkbox,
        Switch
    }

    #endregion CheckBoxStyle

    #region Paginador

    public enum ePaginador
    {
        Ninguno,
        Automatico,
        BotonesNumericos,
        Seleccionador
    }

    #endregion Paginador

    #region Alerts

    public enum eTipoDeAlerta
    {
        Error,
        Advertencia,
        Mensaje,
        Ok
    }

    #endregion Alerts

    #region Icons

    public enum eBoostrapIcons
	{
		None,
		unodostres,
		alarmfill,
		alarm,
		alignbottom,
		aligncenter,
		alignend,
		alignmiddle,
		alignstart,
		aligntop,
		alt,
		appindicator,
		app,
		archivefill,
		archive,
		arrownuevezerodegdown,
		arrownuevezerodegleft,
		arrownuevezerodegright,
		arrownuevezerodegup,
		arrowbardown,
		arrowbarleft,
		arrowbarright,
		arrowbarup,
		arrowclockwise,
		arrowcounterclockwise,
		arrowdowncirclefill,
		arrowdowncircle,
		arrowdownleftcirclefill,
		arrowdownleftcircle,
		arrowdownleftsquarefill,
		arrowdownleftsquare,
		arrowdownleft,
		arrowdownrightcirclefill,
		arrowdownrightcircle,
		arrowdownrightsquarefill,
		arrowdownrightsquare,
		arrowdownright,
		arrowdownshort,
		arrowdownsquarefill,
		arrowdownsquare,
		arrowdownup,
		arrowdown,
		arrowleftcirclefill,
		arrowleftcircle,
		arrowleftright,
		arrowleftshort,
		arrowleftsquarefill,
		arrowleftsquare,
		arrowleft,
		arrowrepeat,
		arrowreturnleft,
		arrowreturnright,
		arrowrightcirclefill,
		arrowrightcircle,
		arrowrightshort,
		arrowrightsquarefill,
		arrowrightsquare,
		arrowright,
		arrowupcirclefill,
		arrowupcircle,
		arrowupleftcirclefill,
		arrowupleftcircle,
		arrowupleftsquarefill,
		arrowupleftsquare,
		arrowupleft,
		arrowuprightcirclefill,
		arrowuprightcircle,
		arrowuprightsquarefill,
		arrowuprightsquare,
		arrowupright,
		arrowupshort,
		arrowupsquarefill,
		arrowupsquare,
		arrowup,
		arrowsanglecontract,
		arrowsangleexpand,
		arrowscollapse,
		arrowsexpand,
		arrowsfullscreen,
		arrowsmove,
		aspectratiofill,
		aspectratio,
		asterisk,
		at,
		awardfill,
		award,
		back,
		backspacefill,
		backspacereversefill,
		backspacereverse,
		backspace,
		badgetresdfill,
		badgetresd,
		badgecuatrokfill,
		badgecuatrok,
		badgeochokfill,
		badgeochok,
		badgeadfill,
		badgead,
		badgearfill,
		badgear,
		badgeccfill,
		badgecc,
		badgehdfill,
		badgehd,
		badgetmfill,
		badgetm,
		badgevofill,
		badgevo,
		badgevrfill,
		badgevr,
		badgewcfill,
		badgewc,
		bagcheckfill,
		bagcheck,
		bagdashfill,
		bagdash,
		bagfill,
		bagplusfill,
		bagplus,
		bagxfill,
		bagx,
		bag,
		barchartfill,
		barchartlinefill,
		barchartline,
		barchartsteps,
		barchart,
		basketfill,
		basket,
		basketdosfill,
		basketdos,
		baskettresfill,
		baskettres,
		batterycharging,
		batteryfull,
		batteryhalf,
		battery,
		bellfill,
		bell,
		bezier,
		bezierdos,
		bicycle,
		binocularsfill,
		binoculars,
		blockquoteleft,
		blockquoteright,
		bookfill,
		bookhalf,
		book,
		bookmarkcheckfill,
		bookmarkcheck,
		bookmarkdashfill,
		bookmarkdash,
		bookmarkfill,
		bookmarkheartfill,
		bookmarkheart,
		bookmarkplusfill,
		bookmarkplus,
		bookmarkstarfill,
		bookmarkstar,
		bookmarkxfill,
		bookmarkx,
		bookmark,
		bookmarksfill,
		bookmarks,
		bookshelf,
		bootstrapfill,
		bootstrapreboot,
		bootstrap,
		borderall,
		borderbottom,
		bordercenter,
		borderinner,
		borderleft,
		bordermiddle,
		borderouter,
		borderright,
		borderstyle,
		bordertop,
		borderwidth,
		border,
		boundingboxcircles,
		boundingbox,
		boxarrowdownleft,
		boxarrowdownright,
		boxarrowdown,
		boxarrowindownleft,
		boxarrowindownright,
		boxarrowindown,
		boxarrowinleft,
		boxarrowinright,
		boxarrowinupleft,
		boxarrowinupright,
		boxarrowinup,
		boxarrowleft,
		boxarrowright,
		boxarrowupleft,
		boxarrowupright,
		boxarrowup,
		boxseam,
		box,
		braces,
		bricks,
		briefcasefill,
		briefcase,
		brightnessalthighfill,
		brightnessalthigh,
		brightnessaltlowfill,
		brightnessaltlow,
		brightnesshighfill,
		brightnesshigh,
		brightnesslowfill,
		brightnesslow,
		broadcastpin,
		broadcast,
		brushfill,
		brush,
		bucketfill,
		bucket,
		bugfill,
		bug,
		building,
		bullseye,
		calculatorfill,
		calculator,
		calendarcheckfill,
		calendarcheck,
		calendardatefill,
		calendardate,
		calendardayfill,
		calendarday,
		calendareventfill,
		calendarevent,
		calendarfill,
		calendarminusfill,
		calendarminus,
		calendarmonthfill,
		calendarmonth,
		calendarplusfill,
		calendarplus,
		calendarrangefill,
		calendarrange,
		calendarweekfill,
		calendarweek,
		calendarxfill,
		calendarx,
		calendar,
		calendardoscheckfill,
		calendardoscheck,
		calendardosdatefill,
		calendardosdate,
		calendardosdayfill,
		calendardosday,
		calendardoseventfill,
		calendardosevent,
		calendardosfill,
		calendardosminusfill,
		calendardosminus,
		calendardosmonthfill,
		calendardosmonth,
		calendardosplusfill,
		calendardosplus,
		calendardosrangefill,
		calendardosrange,
		calendardosweekfill,
		calendardosweek,
		calendardosxfill,
		calendardosx,
		calendardos,
		calendartreseventfill,
		calendartresevent,
		calendartresfill,
		calendartresrangefill,
		calendartresrange,
		calendartresweekfill,
		calendartresweek,
		calendartres,
		calendarcuatroevent,
		calendarcuatrorange,
		calendarcuatroweek,
		calendarcuatro,
		camerafill,
		camerareelsfill,
		camerareels,
		cameravideofill,
		cameravideoofffill,
		cameravideooff,
		cameravideo,
		camera,
		camerados,
		capslockfill,
		capslock,
		cardchecklist,
		cardheading,
		cardimage,
		cardlist,
		cardtext,
		caretdownfill,
		caretdownsquarefill,
		caretdownsquare,
		caretdown,
		caretleftfill,
		caretleftsquarefill,
		caretleftsquare,
		caretleft,
		caretrightfill,
		caretrightsquarefill,
		caretrightsquare,
		caretright,
		caretupfill,
		caretupsquarefill,
		caretupsquare,
		caretup,
		cartcheckfill,
		cartcheck,
		cartdashfill,
		cartdash,
		cartfill,
		cartplusfill,
		cartplus,
		cartxfill,
		cartx,
		cart,
		cartdos,
		carttres,
		cartcuatro,
		cashstack,
		cash,
		cast,
		chatdotsfill,
		chatdots,
		chatfill,
		chatleftdotsfill,
		chatleftdots,
		chatleftfill,
		chatleftquotefill,
		chatleftquote,
		chatlefttextfill,
		chatlefttext,
		chatleft,
		chatquotefill,
		chatquote,
		chatrightdotsfill,
		chatrightdots,
		chatrightfill,
		chatrightquotefill,
		chatrightquote,
		chatrighttextfill,
		chatrighttext,
		chatright,
		chatsquaredotsfill,
		chatsquaredots,
		chatsquarefill,
		chatsquarequotefill,
		chatsquarequote,
		chatsquaretextfill,
		chatsquaretext,
		chatsquare,
		chattextfill,
		chattext,
		chat,
		checkall,
		checkcirclefill,
		checkcircle,
		checksquarefill,
		checksquare,
		check,
		checkdosall,
		checkdoscircle,
		checkdossquare,
		checkdos,
		chevronbarcontract,
		chevronbardown,
		chevronbarexpand,
		chevronbarleft,
		chevronbarright,
		chevronbarup,
		chevroncompactdown,
		chevroncompactleft,
		chevroncompactright,
		chevroncompactup,
		chevroncontract,
		chevrondoubledown,
		chevrondoubleleft,
		chevrondoubleright,
		chevrondoubleup,
		chevrondown,
		chevronexpand,
		chevronleft,
		chevronright,
		chevronup,
		circlefill,
		circlehalf,
		circlesquare,
		circle,
		clipboardcheck,
		clipboarddata,
		clipboardminus,
		clipboardplus,
		clipboardx,
		clipboard,
		clockfill,
		clockhistory,
		clock,
		cloudarrowdownfill,
		cloudarrowdown,
		cloudarrowupfill,
		cloudarrowup,
		cloudcheckfill,
		cloudcheck,
		clouddownloadfill,
		clouddownload,
		clouddrizzlefill,
		clouddrizzle,
		cloudfill,
		cloudfogfill,
		cloudfog,
		cloudfogdosfill,
		cloudfogdos,
		cloudhailfill,
		cloudhail,
		cloudhazefill,
		cloudhaze,
		cloudhazedosfill,
		cloudlightningfill,
		cloudlightningrainfill,
		cloudlightningrain,
		cloudlightning,
		cloudminusfill,
		cloudminus,
		cloudmoonfill,
		cloudmoon,
		cloudplusfill,
		cloudplus,
		cloudrainfill,
		cloudrainheavyfill,
		cloudrainheavy,
		cloudrain,
		cloudslashfill,
		cloudslash,
		cloudsleetfill,
		cloudsleet,
		cloudsnowfill,
		cloudsnow,
		cloudsunfill,
		cloudsun,
		clouduploadfill,
		cloudupload,
		cloud,
		cloudsfill,
		clouds,
		cloudyfill,
		cloudy,
		codeslash,
		codesquare,
		code,
		collectionfill,
		collectionplayfill,
		collectionplay,
		collection,
		columnsgap,
		columns,
		command,
		compassfill,
		compass,
		conestriped,
		cone,
		controller,
		cpufill,
		cpu,
		creditcarddosbackfill,
		creditcarddosback,
		creditcarddosfrontfill,
		creditcarddosfront,
		creditcardfill,
		creditcard,
		crop,
		cupfill,
		cupstraw,
		cup,
		cursorfill,
		cursortext,
		cursor,
		dashcircledotted,
		dashcirclefill,
		dashcircle,
		dashsquaredotted,
		dashsquarefill,
		dashsquare,
		dash,
		diagramdosfill,
		diagramdos,
		diagramtresfill,
		diagramtres,
		diamondfill,
		diamondhalf,
		diamond,
		diceunofill,
		diceuno,
		dicedosfill,
		dicedos,
		dicetresfill,
		dicetres,
		dicecuatrofill,
		dicecuatro,
		dicecincofill,
		dicecinco,
		diceseisfill,
		diceseis,
		discfill,
		disc,
		discord,
		displayfill,
		display,
		distributehorizontal,
		distributevertical,
		doorclosedfill,
		doorclosed,
		dooropenfill,
		dooropen,
		dot,
		download,
		dropletfill,
		droplethalf,
		droplet,
		earbuds,
		easelfill,
		easel,
		eggfill,
		eggfried,
		egg,
		ejectfill,
		eject,
		emojiangryfill,
		emojiangry,
		emojidizzyfill,
		emojidizzy,
		emojiexpressionlessfill,
		emojiexpressionless,
		emojifrownfill,
		emojifrown,
		emojihearteyesfill,
		emojihearteyes,
		emojilaughingfill,
		emojilaughing,
		emojineutralfill,
		emojineutral,
		emojismilefill,
		emojismileupsidedownfill,
		emojismileupsidedown,
		emojismile,
		emojisunglassesfill,
		emojisunglasses,
		emojiwinkfill,
		emojiwink,
		envelopefill,
		envelopeopenfill,
		envelopeopen,
		envelope,
		eraserfill,
		eraser,
		exclamationcirclefill,
		exclamationcircle,
		exclamationdiamondfill,
		exclamationdiamond,
		exclamationoctagonfill,
		exclamationoctagon,
		exclamationsquarefill,
		exclamationsquare,
		exclamationtrianglefill,
		exclamationtriangle,
		exclamation,
		exclude,
		eyefill,
		eyeslashfill,
		eyeslash,
		eye,
		eyedropper,
		eyeglasses,
		facebook,
		filearrowdownfill,
		filearrowdown,
		filearrowupfill,
		filearrowup,
		filebargraphfill,
		filebargraph,
		filebinaryfill,
		filebinary,
		filebreakfill,
		filebreak,
		filecheckfill,
		filecheck,
		filecodefill,
		filecode,
		filedifffill,
		filediff,
		fileearmarkarrowdownfill,
		fileearmarkarrowdown,
		fileearmarkarrowupfill,
		fileearmarkarrowup,
		fileearmarkbargraphfill,
		fileearmarkbargraph,
		fileearmarkbinaryfill,
		fileearmarkbinary,
		fileearmarkbreakfill,
		fileearmarkbreak,
		fileearmarkcheckfill,
		fileearmarkcheck,
		fileearmarkcodefill,
		fileearmarkcode,
		fileearmarkdifffill,
		fileearmarkdiff,
		fileearmarkeaselfill,
		fileearmarkeasel,
		fileearmarkexcelfill,
		fileearmarkexcel,
		fileearmarkfill,
		fileearmarkfontfill,
		fileearmarkfont,
		fileearmarkimagefill,
		fileearmarkimage,
		fileearmarklockfill,
		fileearmarklock,
		fileearmarklockdosfill,
		fileearmarklockdos,
		fileearmarkmedicalfill,
		fileearmarkmedical,
		fileearmarkminusfill,
		fileearmarkminus,
		fileearmarkmusicfill,
		fileearmarkmusic,
		fileearmarkpersonfill,
		fileearmarkperson,
		fileearmarkplayfill,
		fileearmarkplay,
		fileearmarkplusfill,
		fileearmarkplus,
		fileearmarkpostfill,
		fileearmarkpost,
		fileearmarkpptfill,
		fileearmarkppt,
		fileearmarkrichtextfill,
		fileearmarkrichtext,
		fileearmarkruledfill,
		fileearmarkruled,
		fileearmarkslidesfill,
		fileearmarkslides,
		fileearmarkspreadsheetfill,
		fileearmarkspreadsheet,
		fileearmarktextfill,
		fileearmarktext,
		fileearmarkwordfill,
		fileearmarkword,
		fileearmarkxfill,
		fileearmarkx,
		fileearmarkzipfill,
		fileearmarkzip,
		fileearmark,
		fileeaselfill,
		fileeasel,
		fileexcelfill,
		fileexcel,
		filefill,
		filefontfill,
		filefont,
		fileimagefill,
		fileimage,
		filelockfill,
		filelock,
		filelockdosfill,
		filelockdos,
		filemedicalfill,
		filemedical,
		fileminusfill,
		fileminus,
		filemusicfill,
		filemusic,
		filepersonfill,
		fileperson,
		fileplayfill,
		fileplay,
		fileplusfill,
		fileplus,
		filepostfill,
		filepost,
		filepptfill,
		fileppt,
		filerichtextfill,
		filerichtext,
		fileruledfill,
		fileruled,
		fileslidesfill,
		fileslides,
		filespreadsheetfill,
		filespreadsheet,
		filetextfill,
		filetext,
		filewordfill,
		fileword,
		filexfill,
		filex,
		filezipfill,
		filezip,
		file,
		filesalt,
		files,
		film,
		filtercirclefill,
		filtercircle,
		filterleft,
		filterright,
		filtersquarefill,
		filtersquare,
		filter,
		flagfill,
		flag,
		floweruno,
		flowerdos,
		flowertres,
		foldercheck,
		folderfill,
		folderminus,
		folderplus,
		foldersymlinkfill,
		foldersymlink,
		folderx,
		folder,
		folderdosopen,
		folderdos,
		fonts,
		forwardfill,
		forward,
		front,
		fullscreenexit,
		fullscreen,
		funnelfill,
		funnel,
		gearfill,
		gearwideconnected,
		gearwide,
		gear,
		gem,
		geoaltfill,
		geoalt,
		geofill,
		geo,
		giftfill,
		gift,
		github,
		globe,
		globedos,
		google,
		graphdown,
		graphup,
		gridunoxdosfill,
		gridunoxdos,
		gridtresxdosgapfill,
		gridtresxdosgap,
		gridtresxdos,
		gridtresxtresgapfill,
		gridtresxtresgap,
		gridtresxtres,
		gridfill,
		grid,
		griphorizontal,
		gripvertical,
		hammer,
		handindexfill,
		handindexthumbfill,
		handindexthumb,
		handindex,
		handthumbsdownfill,
		handthumbsdown,
		handthumbsupfill,
		handthumbsup,
		handbagfill,
		handbag,
		hash,
		hddfill,
		hddnetworkfill,
		hddnetwork,
		hddrackfill,
		hddrack,
		hddstackfill,
		hddstack,
		hdd,
		headphones,
		headset,
		heartfill,
		hearthalf,
		heart,
		heptagonfill,
		heptagonhalf,
		heptagon,
		hexagonfill,
		hexagonhalf,
		hexagon,
		hourglassbottom,
		hourglasssplit,
		hourglasstop,
		hourglass,
		housedoorfill,
		housedoor,
		housefill,
		house,
		hr,
		hurricane,
		imagealt,
		imagefill,
		image,
		images,
		inboxfill,
		inbox,
		inboxesfill,
		inboxes,
		infocirclefill,
		infocircle,
		infosquarefill,
		infosquare,
		info,
		inputcursortext,
		inputcursor,
		instagram,
		intersect,
		journalalbum,
		journalarrowdown,
		journalarrowup,
		journalbookmarkfill,
		journalbookmark,
		journalcheck,
		journalcode,
		journalmedical,
		journalminus,
		journalplus,
		journalrichtext,
		journaltext,
		journalx,
		journal,
		journals,
		joystick,
		justifyleft,
		justifyright,
		justify,
		kanbanfill,
		kanban,
		keyfill,
		key,
		keyboardfill,
		keyboard,
		ladder,
		lampfill,
		lamp,
		laptopfill,
		laptop,
		layerbackward,
		layerforward,
		layersfill,
		layershalf,
		layers,
		layoutsidebarinsetreverse,
		layoutsidebarinset,
		layoutsidebarreverse,
		layoutsidebar,
		layoutsplit,
		layouttextsidebarreverse,
		layouttextsidebar,
		layouttextwindowreverse,
		layouttextwindow,
		layoutthreecolumns,
		layoutwtf,
		lifepreserver,
		lightbulbfill,
		lightbulbofffill,
		lightbulboff,
		lightbulb,
		lightningchargefill,
		lightningcharge,
		lightningfill,
		lightning,
		linkcuatrocincodeg,
		link,
		linkedin,
		listcheck,
		listnested,
		listol,
		liststars,
		listtask,
		listul,
		list,
		lockfill,
		locknormal,
		mailbox,
		mailboxdos,
		mapfill,
		map,
		markdownfill,
		markdown,
		mask,
		megaphonefill,
		megaphone,
		menuappfill,
		menuapp,
		menubuttonfill,
		menubuttonwidefill,
		menubuttonwide,
		menubutton,
		menudown,
		menuup,
		micfill,
		micmutefill,
		micmute,
		mic,
		minecartloaded,
		minecart,
		moisture,
		moonfill,
		moonstarsfill,
		moonstars,
		moon,
		mousefill,
		mouse,
		mousedosfill,
		mousedos,
		mousetresfill,
		mousetres,
		musicnotebeamed,
		musicnotelist,
		musicnote,
		musicplayerfill,
		musicplayer,
		newspaper,
		nodeminusfill,
		nodeminus,
		nodeplusfill,
		nodeplus,
		nutfill,
		nut,
		octagonfill,
		octagonhalf,
		octagon,
		option,
		outlet,
		paintbucket,
		palettefill,
		palette,
		palettedos,
		paperclip,
		paragraph,
		patchcheckfill,
		patchcheck,
		patchexclamationfill,
		patchexclamation,
		patchminusfill,
		patchminus,
		patchplusfill,
		patchplus,
		patchquestionfill,
		patchquestion,
		pausebtnfill,
		pausebtn,
		pausecirclefill,
		pausecircle,
		pausefill,
		pause,
		peacefill,
		peace,
		penfill,
		pen,
		pencilfill,
		pencilsquare,
		pencil,
		pentagonfill,
		pentagonhalf,
		pentagon,
		peoplefill,
		people,
		percent,
		personbadgefill,
		personbadge,
		personboundingbox,
		personcheckfill,
		personcheck,
		personcircle,
		persondashfill,
		persondash,
		personfill,
		personlinesfill,
		personplusfill,
		personplus,
		personsquare,
		personxfill,
		personx,
		person,
		phonefill,
		phonelandscapefill,
		phonelandscape,
		phonevibratefill,
		phonevibrate,
		phone,
		piechartfill,
		piechart,
		pinanglefill,
		pinangle,
		pinfill,
		pin,
		pipfill,
		pip,
		playbtnfill,
		playbtn,
		playcirclefill,
		playcircle,
		playfill,
		play,
		plugfill,
		plug,
		pluscircledotted,
		pluscirclefill,
		pluscircle,
		plussquaredotted,
		plussquarefill,
		plussquare,
		plus,
		power,
		printerfill,
		printer,
		puzzlefill,
		puzzle,
		questioncirclefill,
		questioncircle,
		questiondiamondfill,
		questiondiamond,
		questionoctagonfill,
		questionoctagon,
		questionsquarefill,
		questionsquare,
		question,
		rainbow,
		receiptcutoff,
		receipt,
		receptionzero,
		receptionuno,
		receptiondos,
		receptiontres,
		receptioncuatro,
		recordbtnfill,
		recordbtn,
		recordcirclefill,
		recordcircle,
		recordfill,
		record,
		recorddosfill,
		recorddos,
		replyallfill,
		replyall,
		replyfill,
		reply,
		rssfill,
		rss,
		rulers,
		savefill,
		save,
		savedosfill,
		savedos,
		scissors,
		screwdriver,
		search,
		segmentednav,
		server,
		sharefill,
		share,
		shieldcheck,
		shieldexclamation,
		shieldfillcheck,
		shieldfillexclamation,
		shieldfillminus,
		shieldfillplus,
		shieldfillx,
		shieldfill,
		shieldlockfill,
		shieldlock,
		shieldminus,
		shieldplus,
		shieldshaded,
		shieldslashfill,
		shieldslash,
		shieldx,
		shield,
		shiftfill,
		shift,
		shopwindow,
		shop,
		shuffle,
		signpostdosfill,
		signpostdos,
		signpostfill,
		signpostsplitfill,
		signpostsplit,
		signpost,
		simfill,
		sim,
		skipbackwardbtnfill,
		skipbackwardbtn,
		skipbackwardcirclefill,
		skipbackwardcircle,
		skipbackwardfill,
		skipbackward,
		skipendbtnfill,
		skipendbtn,
		skipendcirclefill,
		skipendcircle,
		skipendfill,
		skipend,
		skipforwardbtnfill,
		skipforwardbtn,
		skipforwardcirclefill,
		skipforwardcircle,
		skipforwardfill,
		skipforward,
		skipstartbtnfill,
		skipstartbtn,
		skipstartcirclefill,
		skipstartcircle,
		skipstartfill,
		skipstart,
		slack,
		slashcirclefill,
		slashcircle,
		slashsquarefill,
		slashsquare,
		slash,
		sliders,
		smartwatch,
		snow,
		snowdos,
		snowtres,
		sortalphadownalt,
		sortalphadown,
		sortalphaupalt,
		sortalphaup,
		sortdownalt,
		sortdown,
		sortnumericdownalt,
		sortnumericdown,
		sortnumericupalt,
		sortnumericup,
		sortupalt,
		sortup,
		soundwave,
		speakerfill,
		speaker,
		speedometer,
		speedometerdos,
		spellcheck,
		squarefill,
		squarehalf,
		square,
		stack,
		starfill,
		starhalf,
		star,
		stars,
		stickiesfill,
		stickies,
		stickyfill,
		sticky,
		stopbtnfill,
		stopbtn,
		stopcirclefill,
		stopcircle,
		stopfill,
		stop,
		stoplightsfill,
		stoplights,
		stopwatchfill,
		stopwatch,
		subtract,
		suitclubfill,
		suitclub,
		suitdiamondfill,
		suitdiamond,
		suitheartfill,
		suitheart,
		suitspadefill,
		suitspade,
		sunfill,
		sun,
		sunglasses,
		sunrisefill,
		sunrise,
		sunsetfill,
		sunset,
		symmetryhorizontal,
		symmetryvertical,
		table,
		tabletfill,
		tabletlandscapefill,
		tabletlandscape,
		tablet,
		tagfill,
		tag,
		tagsfill,
		tags,
		telegram,
		telephonefill,
		telephoneforwardfill,
		telephoneforward,
		telephoneinboundfill,
		telephoneinbound,
		telephoneminusfill,
		telephoneminus,
		telephoneoutboundfill,
		telephoneoutbound,
		telephoneplusfill,
		telephoneplus,
		telephonexfill,
		telephonex,
		telephone,
		terminalfill,
		terminal,
		textcenter,
		textindentleft,
		textindentright,
		textleft,
		textparagraph,
		textright,
		textarearesize,
		textareat,
		textarea,
		thermometerhalf,
		thermometerhigh,
		thermometerlow,
		thermometersnow,
		thermometersun,
		thermometer,
		threedotsvertical,
		threedots,
		toggleoff,
		toggleon,
		toggledosoff,
		toggledoson,
		toggles,
		togglesdos,
		tools,
		tornado,
		trashfill,
		trash,
		trashdosfill,
		trashdos,
		treefill,
		tree,
		trianglefill,
		trianglehalf,
		triangle,
		trophyfill,
		trophy,
		tropicalstorm,
		truckflatbed,
		truck,
		tsunami,
		tvfill,
		tv,
		twitch,
		twitter,
		typebold,
		typehuno,
		typehdos,
		typehtres,
		typeitalic,
		typestrikethrough,
		typeunderline,
		type,
		uichecksgrid,
		uichecks,
		uiradiosgrid,
		uiradios,
		umbrellafill,
		umbrella,
		union,
		unlockfill,
		unlock,
		upcscan,
		upc,
		upload,
		vectorpen,
		viewlist,
		viewstacked,
		vinylfill,
		vinyl,
		voicemail,
		volumedownfill,
		volumedown,
		volumemutefill,
		volumemute,
		volumeofffill,
		volumeoff,
		volumeupfill,
		volumeup,
		vr,
		walletfill,
		wallet,
		walletdos,
		watch,
		water,
		whatsapp,
		wifiuno,
		wifidos,
		wifioff,
		wifi,
		wind,
		windowdock,
		windowsidebar,
		window,
		wrench,
		xcirclefill,
		xcircle,
		xdiamondfill,
		xdiamond,
		xoctagonfill,
		xoctagon,
		xsquarefill,
		xsquare,
		x,
		youtube,
		zoomin,
		zoomout,
		bank,
		bankdos,
		bellslashfill,
		bellslash,
		cashcoin,
		checklg,
		coin,
		currencybitcoin,
		currencydollar,
		currencyeuro,
		currencyexchange,
		currencypound,
		currencyyen,
		dashlg,
		exclamationlg,
		fileearmarkpdffill,
		fileearmarkpdf,
		filepdffill,
		filepdf,
		genderambiguous,
		genderfemale,
		gendermale,
		gendertrans,
		headsetvr,
		infolg,
		mastodon,
		messenger,
		piggybankfill,
		piggybank,
		pinmapfill,
		pinmap,
		pluslg,
		questionlg,
		recycle,
		reddit,
		safefill,
		safedosfill,
		safedos,
		sdcardfill,
		sdcard,
		skype,
		slashlg,
		translate,
		xlg,
		safe,
		apple,
		microsoft,
		windows,
		behance,
		dribbble,
		line,
		medium,
		paypal,
		pinterest,
		signal,
		snapchat,
		spotify,
		stackoverflow,
		strava,
		wordpress,
		vimeo,
		activity,
		easeldosfill,
		easeldos,
		easeltresfill,
		easeltres,
		fan,
		fingerprint,
		graphdownarrow,
		graphuparrow,
		hypnotize,
		magic,
		personrolodex,
		personvideo,
		personvideodos,
		personvideotres,
		personworkspace,
		radioactive,
		webcamfill,
		webcam,
		yinyang,
		bandaidfill,
		bandaid,
		bluetooth,
		bodytext,
		boombox,
		boxes,
		dpadfill,
		dpad,
		earfill,
		ear,
		envelopecheckfill,
		envelopecheck,
		envelopedashfill,
		envelopedash,
		envelopeexclamationfill,
		envelopeexclamation,
		envelopeplusfill,
		envelopeplus,
		envelopeslashfill,
		envelopeslash,
		envelopexfill,
		envelopex,
		explicitfill,
		explicitnormal,
		git,
		infinity,
		listcolumnsreverse,
		listcolumns,
		meta,
		nintendoswitch,
		pcdisplayhorizontal,
		pcdisplay,
		pchorizontal,
		pc,
		playstation,
		plusslashminus,
		projectorfill,
		projector,
		qrcodescan,
		qrcode,
		quora,
		quote,
		robot,
		sendcheckfill,
		sendcheck,
		senddashfill,
		senddash,
		sendexclamationfill,
		sendexclamation,
		sendfill,
		sendplusfill,
		sendplus,
		sendslashfill,
		sendslash,
		sendxfill,
		sendx,
		send,
		steam,
		terminaldash,
		terminalplus,
		terminalsplit,
		ticketdetailedfill,
		ticketdetailed,
		ticketfill,
		ticketperforatedfill,
		ticketperforated,
		ticket,
		tiktok,
		windowdash,
		windowdesktop,
		windowfullscreen,
		windowplus,
		windowsplit,
		windowstack,
		windowx,
		xbox,
		ethernet,
		hdmifill,
		hdmi,
		usbcfill,
		usbc,
		usbfill,
		usbplugfill,
		usbplug,
		usbsymbol,
		usb,
		boomboxfill,
		displayport,
		gpucard,
		memory,
		modemfill,
		modem,
		motherboardfill,
		motherboard,
		opticalaudiofill,
		opticalaudio,
		pcicard,
		routerfill,
		router,
		thunderboltfill,
		thunderbolt,
		usbdrivefill,
		usbdrive,
		usbmicrofill,
		usbmicro,
		usbminifill,
		usbmini,
		cloudhazedos,
		devicehddfill,
		devicehdd,
		devicessdfill,
		devicessd,
		displayportfill,
		mortarboardfill,
		mortarboard,
		terminalx,
		arrowthroughheartfill,
		arrowthroughheart,
		badgesdfill,
		badgesd,
		bagheartfill,
		bagheart,
		balloonfill,
		balloonheartfill,
		balloonheart,
		balloon,
		boxdosfill,
		boxdosheartfill,
		boxdosheart,
		boxdos,
		bracesasterisk,
		calendarheartfill,
		calendarheart,
		calendardosheartfill,
		calendardosheart,
		chatheartfill,
		chatheart,
		chatleftheartfill,
		chatleftheart,
		chatrightheartfill,
		chatrightheart,
		chatsquareheartfill,
		chatsquareheart,
		clipboardcheckfill,
		clipboarddatafill,
		clipboardfill,
		clipboardheartfill,
		clipboardheart,
		clipboardminusfill,
		clipboardplusfill,
		clipboardpulse,
		clipboardxfill,
		clipboarddoscheckfill,
		clipboarddoscheck,
		clipboarddosdatafill,
		clipboarddosdata,
		clipboarddosfill,
		clipboarddosheartfill,
		clipboarddosheart,
		clipboarddosminusfill,
		clipboarddosminus,
		clipboarddosplusfill,
		clipboarddosplus,
		clipboarddospulsefill,
		clipboarddospulse,
		clipboarddosxfill,
		clipboarddosx,
		clipboarddos,
		emojikissfill,
		emojikiss,
		envelopeheartfill,
		envelopeheart,
		envelopeopenheartfill,
		envelopeopenheart,
		envelopepaperfill,
		envelopepaperheartfill,
		envelopepaperheart,
		envelopepaper,
		filetypeaac,
		filetypeai,
		filetypebmp,
		filetypecs,
		filetypecss,
		filetypecsv,
		filetypedoc,
		filetypedocx,
		filetypeexe,
		filetypegif,
		filetypeheic,
		filetypehtml,
		filetypejava,
		filetypejpg,
		filetypejs,
		filetypejsx,
		filetypekey,
		filetypemcuatrop,
		filetypemd,
		filetypemdx,
		filetypemov,
		filetypemptres,
		filetypempcuatro,
		filetypeotf,
		filetypepdf,
		filetypephp,
		filetypepng,
		filetypeppt,
		filetypepsd,
		filetypepy,
		filetyperaw,
		filetyperb,
		filetypesass,
		filetypescss,
		filetypesh,
		filetypesvg,
		filetypetiff,
		filetypetsx,
		filetypettf,
		filetypetxt,
		filetypewav,
		filetypewoff,
		filetypexls,
		filetypexml,
		filetypeyml,
		heartarrow,
		heartpulsefill,
		heartpulse,
		heartbreakfill,
		heartbreak,
		hearts,
		hospitalfill,
		hospital,
		househeartfill,
		househeart,
		incognito,
		magnetfill,
		magnet,
		personheart,
		personhearts,
		phoneflip,
		plugin,
		postagefill,
		postageheartfill,
		postageheart,
		postage,
		postcardfill,
		postcardheartfill,
		postcardheart,
		postcard,
		searchheartfill,
		searchheart,
		slidersdosvertical,
		slidersdos,
		trashtresfill,
		trashtres,
		valentine,
		valentinedos,
		wrenchadjustablecirclefill,
		wrenchadjustablecircle,
		wrenchadjustable,
		filetypejson,
		filetypepptx,
		filetypexlsx,
		unocirclefill,
		unocircle,
		unosquarefill,
		unosquare,
		doscirclefill,
		doscircle,
		dossquarefill,
		dossquare,
		trescirclefill,
		trescircle,
		tressquarefill,
		tressquare,
		cuatrocirclefill,
		cuatrocircle,
		cuatrosquarefill,
		cuatrosquare,
		cincocirclefill,
		cincocircle,
		cincosquarefill,
		cincosquare,
		seiscirclefill,
		seiscircle,
		seissquarefill,
		seissquare,
		sietecirclefill,
		sietecircle,
		sietesquarefill,
		sietesquare,
		ochocirclefill,
		ochocircle,
		ochosquarefill,
		ochosquare,
		nuevecirclefill,
		nuevecircle,
		nuevesquarefill,
		nuevesquare,
		airplaneenginesfill,
		airplaneengines,
		airplanefill,
		airplane,
		alexa,
		alipay,
		android,
		androiddos,
		boxfill,
		boxseamfill,
		browserchrome,
		browseredge,
		browserfirefox,
		browsersafari,
		ccirclefill,
		ccircle,
		csquarefill,
		csquare,
		capsulepill,
		capsule,
		carfrontfill,
		carfront,
		cassettefill,
		cassette,
		cccirclefill,
		cccircle,
		ccsquarefill,
		ccsquare,
		cuphotfill,
		cuphot,
		currencyrupee,
		dropbox,
		escape,
		fastforwardbtnfill,
		fastforwardbtn,
		fastforwardcirclefill,
		fastforwardcircle,
		fastforwardfill,
		fastforward,
		filetypesql,
		fire,
		googleplay,
		hcirclefill,
		hcircle,
		hsquarefill,
		hsquare,
		indent,
		lungsfill,
		lungs,
		microsoftteams,
		pcirclefill,
		pcircle,
		psquarefill,
		psquare,
		passfill,
		pass,
		prescription,
		prescriptiondos,
		rcirclefill,
		rcircle,
		rsquarefill,
		rsquare,
		repeatuno,
		repeat,
		rewindbtnfill,
		rewindbtn,
		rewindcirclefill,
		rewindcircle,
		rewindfill,
		rewind,
		trainfreightfrontfill,
		trainfreightfront,
		trainfrontfill,
		trainfront,
		trainlightrailfrontfill,
		trainlightrailfront,
		truckfrontfill,
		truckfront,
		ubuntu,
		unindent,
		unity,
		universalaccesscircle,
		universalaccess,
		virus,
		virusdos,
		wechat,
		yelp,
		signstopfill,
		signstoplightsfill,
		signstoplights,
		signstop,
		signturnleftfill,
		signturnleft,
		signturnrightfill,
		signturnright,
		signturnslightleftfill,
		signturnslightleft,
		signturnslightrightfill,
		signturnslightright,
		signyieldfill,
		signyield,
		evstationfill,
		evstation,
		fuelpumpdieselfill,
		fuelpumpdiesel,
		fuelpumpfill,
		fuelpump,
		zerocirclefill,
		zerocircle,
		zerosquarefill,
		zerosquare,
		rocketfill,
		rockettakeofffill,
		rockettakeoff,
		rocket,
		stripe,
		subscript,
		superscript,
		trello,
		envelopeatfill,
		envelopeat,
		regex,
		textwrap,
		signdeadendfill,
		signdeadend,
		signdonotenterfill,
		signdonotenter,
		signintersectionfill,
		signintersectionsidefill,
		signintersectionside,
		signintersectiontfill,
		signintersectiont,
		signintersectionyfill,
		signintersectiony,
		signintersection,
		signmergeleftfill,
		signmergeleft,
		signmergerightfill,
		signmergeright,
		signnoleftturnfill,
		signnoleftturn,
		signnoparkingfill,
		signnoparking,
		signnorightturnfill,
		signnorightturn,
		signrailroadfill,
		signrailroad,
		buildingadd,
		buildingcheck,
		buildingdash,
		buildingdown,
		buildingexclamation,
		buildingfilladd,
		buildingfillcheck,
		buildingfilldash,
		buildingfilldown,
		buildingfillexclamation,
		buildingfillgear,
		buildingfilllock,
		buildingfillslash,
		buildingfillup,
		buildingfillx,
		buildingfill,
		buildinggear,
		buildinglock,
		buildingslash,
		buildingup,
		buildingx,
		buildingsfill,
		buildings,
		busfrontfill,
		busfront,
		evfrontfill,
		evfront,
		globeamericas,
		globeasiaaustralia,
		globecentralsouthasia,
		globeeuropeafrica,
		houseaddfill,
		houseadd,
		housecheckfill,
		housecheck,
		housedashfill,
		housedash,
		housedownfill,
		housedown,
		houseexclamationfill,
		houseexclamation,
		housegearfill,
		housegear,
		houselockfill,
		houselock,
		houseslashfill,
		houseslash,
		houseupfill,
		houseup,
		housexfill,
		housex,
		personadd,
		persondown,
		personexclamation,
		personfilladd,
		personfillcheck,
		personfilldash,
		personfilldown,
		personfillexclamation,
		personfillgear,
		personfilllock,
		personfillslash,
		personfillup,
		personfillx,
		persongear,
		personlock,
		personslash,
		personup,
		scooter,
		taxifrontfill,
		taxifront,
		amd,
		databaseadd,
		databasecheck,
		databasedash,
		databasedown,
		databaseexclamation,
		databasefilladd,
		databasefillcheck,
		databasefilldash,
		databasefilldown,
		databasefillexclamation,
		databasefillgear,
		databasefilllock,
		databasefillslash,
		databasefillup,
		databasefillx,
		databasefill,
		databasegear,
		databaselock,
		databaseslash,
		databaseup,
		databasex,
		database,
		housesfill,
		houses,
		nvidia,
		personvcardfill,
		personvcard,
		sinaweibo,
		tencentqq,
		wikipedia
	};

    #endregion Icons

    #region OData

    public enum eODataFilter
    {
        Igual,
        Diferente,
        Contiene,
        NoContiene,
        EmpiezaCon,
        TerminaCon,
        MayorQue,
        MayorOIgualQue,
        MenorQue,
        MenorOIgualQue,
    }

    #endregion OData

    public class WoDesignOptions
	{
		#region Common Containers Items

		public Dictionary<string, string> ContainerItemColor = new Dictionary<string, string>()
		{
			{ "Default", "" },
			{ "Primary", "bg-primary" },
			{ "Secondary", "bg-secondary" },
			{ "Success", "bg-success" },
			{ "Danger", "bg-danger" },
			{ "Warning", "bg-warning" },
			{ "Info", "bg-info" },
			{ "Light", "bg-light" },
			{ "Dark", "bg-dark" }
		};

		#endregion Common Containers Items

		#region Group

		public Dictionary<string, string> BackgroundColor = new Dictionary<string, string>()
		{
			{ "Default", "" },
			{ "Primary", "bg-primary" },
			{ "Secondary", "bg-secondary" },
			{ "Success", "bg-success" },
			{ "Danger", "bg-danger" },
			{ "Warning", "bg-warning" },
			{ "Info", "bg-info" },
			{ "Light", "bg-light" },
			{ "Dark", "bg-dark" },
			{ "BorderPrimary", "border-primary" },
			{ "BorderSecondary", "border-secondary" },
			{ "BorderSuccess", "border-success" },
			{ "BorderDanger", "border-danger" },
			{ "BorderWarning", "border-warning" },
			{ "BorderInfo", "border-info" },
			{ "BorderLight", "border-light" },
			{ "BorderDark", "border-dark" }
		};

		#endregion Group

		#region Common Item

		public Dictionary<string, string> ItemEnabled = new Dictionary<string, string>()
		{
			{ "Activo", "" },
			{ "Inactivo", "disabled" }
		};

		public Dictionary<string, string> ItemSize = new Dictionary<string, string>()
		{
			{ "Large", "form-control-lg" },
			{ "Normal", "" },
			{ "Small", "form-control-sm" }
		};

		#endregion Common Item

		#region Button

		public Dictionary<string, string> ButtonSize = new Dictionary<string, string>()
		{
			{ "Grande", "btn-lg" },
			{ "Normal", "" },
			{ "Pequeño", "btn-sm" }
		};

		public Dictionary<string, string> ButtonColor = new Dictionary<string, string>()
		{
			{ "Default", "" },
			{ "Primary", "btn-primary" },
			{ "Secondary", "btn-secondary" },
			{ "Success", "btn-success" },
			{ "Info", "btn-info" },
			{ "Warning", "btn-warning" },
			{ "Danger", "btn-danger" },
			{ "Light", "btn-light" },
			{ "Dark", "btn-dark" },
			{ "Link", "btn-link" },
			{ "OutlinePrimary", "btn-outline-primary" },
			{ "OutlineSecondary", "btn-outline-secondary" },
			{ "OutlineSuccess", "btn-outline-success" },
			{ "OutlineInfo", "btn-outline-info" },
			{ "OutlineWarning", "btn-outline-warning" },
			{ "OutlineDanger", "btn-outline-danger" },
			{ "OutlineLight", "btn-outline-light" },
			{ "OutlineDark", "btn-outline-dark" }
		};

		#endregion Button

		#region Text

		public Dictionary<string, string> TextColor = new Dictionary<string, string>()
		{
			{ "FontDefault", "" },
			{ "Primary", "text-primary" },
			{ "Secondary", "text-secondary" },
			{ "Warning", "text-warning" },
			{ "Danger", "text-danger" },
			{ "Success", "text-success" },
			{ "Info", "text-info" },
			{ "Muted", "text-muted" },
			{ "Light", "text-light" },
			{ "Dark", "text-dark" },
			{ "Black", "text-black" },
			{ "White", "text-white" },
		};

		public Dictionary<string, string> TextSize = new Dictionary<string, string>()
		{
			{ "Large", "fs-4" },
			{ "Normal", "fs-5" },
			{ "Small", "fs-6" }
		};

		public Dictionary<string, string> TextWeight = new Dictionary<string, string>()
		{
			{ "Bold", "fw-bold" },
			{ "Normal", "" },
			{ "Light", "fw-light" }
		};

		public Dictionary<string, string> TextItalic = new Dictionary<string, string>()
		{
			{ "None", "" },
			{ "Italic", "fst-italic" }
		};

		public Dictionary<string, string> TextDecoration = new Dictionary<string, string>()
		{
			{ "None", "text-decoration-none" },
			{ "Underline", "text-decoration-underline" },
			{ "Through", "text-decoration-line-through" }
		};

		#endregion Text

		#region Table

		public Dictionary<string, string> TableDesign = new Dictionary<string, string>()
		{
			{ "None", "" },
			{ "Hover", "table-hover" }
		};

		public Dictionary<string, string> TableRowColor = new Dictionary<string, string>()
		{
			{ "Default", "" },
			{ "Active", "table-active" },
			{ "Primary", "table-primary" },
			{ "Secondary", "table-secondary" },
			{ "Success", "table-success" },
			{ "Danger", "table-danger" },
			{ "Warning", "table-warning" },
			{ "Info", "table-info" },
			{ "Light", "table-light" },
			{ "Dark", "table-dark" },
		};

		#endregion Table

		#region Icon

		public Dictionary<string, string> BoostrapIcons = new Dictionary<string, string>()
		{
			{ "None", "" },
			{ "unodostres", "123" },
			{ "alarmfill", "alarm-fill" },
			{ "alarm", "alarm" },
			{ "alignbottom", "align-bottom" },
			{ "aligncenter", "align-center" },
			{ "alignend", "align-end" },
			{ "alignmiddle", "align-middle" },
			{ "alignstart", "align-start" },
			{ "aligntop", "align-top" },
			{ "alt", "alt" },
			{ "appindicator", "app-indicator" },
			{ "app", "app" },
			{ "archivefill", "archive-fill" },
			{ "archive", "archive" },
			{ "arrownuevezerodegdown", "arrow-90deg-down" },
			{ "arrownuevezerodegleft", "arrow-90deg-left" },
			{ "arrownuevezerodegright", "arrow-90deg-right" },
			{ "arrownuevezerodegup", "arrow-90deg-up" },
			{ "arrowbardown", "arrow-bar-down" },
			{ "arrowbarleft", "arrow-bar-left" },
			{ "arrowbarright", "arrow-bar-right" },
			{ "arrowbarup", "arrow-bar-up" },
			{ "arrowclockwise", "arrow-clockwise" },
			{ "arrowcounterclockwise", "arrow-counterclockwise" },
			{ "arrowdowncirclefill", "arrow-down-circle-fill" },
			{ "arrowdowncircle", "arrow-down-circle" },
			{ "arrowdownleftcirclefill", "arrow-down-left-circle-fill" },
			{ "arrowdownleftcircle", "arrow-down-left-circle" },
			{ "arrowdownleftsquarefill", "arrow-down-left-square-fill" },
			{ "arrowdownleftsquare", "arrow-down-left-square" },
			{ "arrowdownleft", "arrow-down-left" },
			{ "arrowdownrightcirclefill", "arrow-down-right-circle-fill" },
			{ "arrowdownrightcircle", "arrow-down-right-circle" },
			{ "arrowdownrightsquarefill", "arrow-down-right-square-fill" },
			{ "arrowdownrightsquare", "arrow-down-right-square" },
			{ "arrowdownright", "arrow-down-right" },
			{ "arrowdownshort", "arrow-down-short" },
			{ "arrowdownsquarefill", "arrow-down-square-fill" },
			{ "arrowdownsquare", "arrow-down-square" },
			{ "arrowdownup", "arrow-down-up" },
			{ "arrowdown", "arrow-down" },
			{ "arrowleftcirclefill", "arrow-left-circle-fill" },
			{ "arrowleftcircle", "arrow-left-circle" },
			{ "arrowleftright", "arrow-left-right" },
			{ "arrowleftshort", "arrow-left-short" },
			{ "arrowleftsquarefill", "arrow-left-square-fill" },
			{ "arrowleftsquare", "arrow-left-square" },
			{ "arrowleft", "arrow-left" },
			{ "arrowrepeat", "arrow-repeat" },
			{ "arrowreturnleft", "arrow-return-left" },
			{ "arrowreturnright", "arrow-return-right" },
			{ "arrowrightcirclefill", "arrow-right-circle-fill" },
			{ "arrowrightcircle", "arrow-right-circle" },
			{ "arrowrightshort", "arrow-right-short" },
			{ "arrowrightsquarefill", "arrow-right-square-fill" },
			{ "arrowrightsquare", "arrow-right-square" },
			{ "arrowright", "arrow-right" },
			{ "arrowupcirclefill", "arrow-up-circle-fill" },
			{ "arrowupcircle", "arrow-up-circle" },
			{ "arrowupleftcirclefill", "arrow-up-left-circle-fill" },
			{ "arrowupleftcircle", "arrow-up-left-circle" },
			{ "arrowupleftsquarefill", "arrow-up-left-square-fill" },
			{ "arrowupleftsquare", "arrow-up-left-square" },
			{ "arrowupleft", "arrow-up-left" },
			{ "arrowuprightcirclefill", "arrow-up-right-circle-fill" },
			{ "arrowuprightcircle", "arrow-up-right-circle" },
			{ "arrowuprightsquarefill", "arrow-up-right-square-fill" },
			{ "arrowuprightsquare", "arrow-up-right-square" },
			{ "arrowupright", "arrow-up-right" },
			{ "arrowupshort", "arrow-up-short" },
			{ "arrowupsquarefill", "arrow-up-square-fill" },
			{ "arrowupsquare", "arrow-up-square" },
			{ "arrowup", "arrow-up" },
			{ "arrowsanglecontract", "arrows-angle-contract" },
			{ "arrowsangleexpand", "arrows-angle-expand" },
			{ "arrowscollapse", "arrows-collapse" },
			{ "arrowsexpand", "arrows-expand" },
			{ "arrowsfullscreen", "arrows-fullscreen" },
			{ "arrowsmove", "arrows-move" },
			{ "aspectratiofill", "aspect-ratio-fill" },
			{ "aspectratio", "aspect-ratio" },
			{ "asterisk", "asterisk" },
			{ "at", "at" },
			{ "awardfill", "award-fill" },
			{ "award", "award" },
			{ "back", "back" },
			{ "backspacefill", "backspace-fill" },
			{ "backspacereversefill", "backspace-reverse-fill" },
			{ "backspacereverse", "backspace-reverse" },
			{ "backspace", "backspace" },
			{ "badgetresdfill", "badge-3d-fill" },
			{ "badgetresd", "badge-3d" },
			{ "badgecuatrokfill", "badge-4k-fill" },
			{ "badgecuatrok", "badge-4k" },
			{ "badgeochokfill", "badge-8k-fill" },
			{ "badgeochok", "badge-8k" },
			{ "badgeadfill", "badge-ad-fill" },
			{ "badgead", "badge-ad" },
			{ "badgearfill", "badge-ar-fill" },
			{ "badgear", "badge-ar" },
			{ "badgeccfill", "badge-cc-fill" },
			{ "badgecc", "badge-cc" },
			{ "badgehdfill", "badge-hd-fill" },
			{ "badgehd", "badge-hd" },
			{ "badgetmfill", "badge-tm-fill" },
			{ "badgetm", "badge-tm" },
			{ "badgevofill", "badge-vo-fill" },
			{ "badgevo", "badge-vo" },
			{ "badgevrfill", "badge-vr-fill" },
			{ "badgevr", "badge-vr" },
			{ "badgewcfill", "badge-wc-fill" },
			{ "badgewc", "badge-wc" },
			{ "bagcheckfill", "bag-check-fill" },
			{ "bagcheck", "bag-check" },
			{ "bagdashfill", "bag-dash-fill" },
			{ "bagdash", "bag-dash" },
			{ "bagfill", "bag-fill" },
			{ "bagplusfill", "bag-plus-fill" },
			{ "bagplus", "bag-plus" },
			{ "bagxfill", "bag-x-fill" },
			{ "bagx", "bag-x" },
			{ "bag", "bag" },
			{ "barchartfill", "bar-chart-fill" },
			{ "barchartlinefill", "bar-chart-line-fill" },
			{ "barchartline", "bar-chart-line" },
			{ "barchartsteps", "bar-chart-steps" },
			{ "barchart", "bar-chart" },
			{ "basketfill", "basket-fill" },
			{ "basket", "basket" },
			{ "basketdosfill", "basket2-fill" },
			{ "basketdos", "basket2" },
			{ "baskettresfill", "basket3-fill" },
			{ "baskettres", "basket3" },
			{ "batterycharging", "battery-charging" },
			{ "batteryfull", "battery-full" },
			{ "batteryhalf", "battery-half" },
			{ "battery", "battery" },
			{ "bellfill", "bell-fill" },
			{ "bell", "bell" },
			{ "bezier", "bezier" },
			{ "bezierdos", "bezier2" },
			{ "bicycle", "bicycle" },
			{ "binocularsfill", "binoculars-fill" },
			{ "binoculars", "binoculars" },
			{ "blockquoteleft", "blockquote-left" },
			{ "blockquoteright", "blockquote-right" },
			{ "bookfill", "book-fill" },
			{ "bookhalf", "book-half" },
			{ "book", "book" },
			{ "bookmarkcheckfill", "bookmark-check-fill" },
			{ "bookmarkcheck", "bookmark-check" },
			{ "bookmarkdashfill", "bookmark-dash-fill" },
			{ "bookmarkdash", "bookmark-dash" },
			{ "bookmarkfill", "bookmark-fill" },
			{ "bookmarkheartfill", "bookmark-heart-fill" },
			{ "bookmarkheart", "bookmark-heart" },
			{ "bookmarkplusfill", "bookmark-plus-fill" },
			{ "bookmarkplus", "bookmark-plus" },
			{ "bookmarkstarfill", "bookmark-star-fill" },
			{ "bookmarkstar", "bookmark-star" },
			{ "bookmarkxfill", "bookmark-x-fill" },
			{ "bookmarkx", "bookmark-x" },
			{ "bookmark", "bookmark" },
			{ "bookmarksfill", "bookmarks-fill" },
			{ "bookmarks", "bookmarks" },
			{ "bookshelf", "bookshelf" },
			{ "bootstrapfill", "bootstrap-fill" },
			{ "bootstrapreboot", "bootstrap-reboot" },
			{ "bootstrap", "bootstrap" },
			{ "borderall", "border-all" },
			{ "borderbottom", "border-bottom" },
			{ "bordercenter", "border-center" },
			{ "borderinner", "border-inner" },
			{ "borderleft", "border-left" },
			{ "bordermiddle", "border-middle" },
			{ "borderouter", "border-outer" },
			{ "borderright", "border-right" },
			{ "borderstyle", "border-style" },
			{ "bordertop", "border-top" },
			{ "borderwidth", "border-width" },
			{ "border", "border" },
			{ "boundingboxcircles", "bounding-box-circles" },
			{ "boundingbox", "bounding-box" },
			{ "boxarrowdownleft", "box-arrow-down-left" },
			{ "boxarrowdownright", "box-arrow-down-right" },
			{ "boxarrowdown", "box-arrow-down" },
			{ "boxarrowindownleft", "box-arrow-in-down-left" },
			{ "boxarrowindownright", "box-arrow-in-down-right" },
			{ "boxarrowindown", "box-arrow-in-down" },
			{ "boxarrowinleft", "box-arrow-in-left" },
			{ "boxarrowinright", "box-arrow-in-right" },
			{ "boxarrowinupleft", "box-arrow-in-up-left" },
			{ "boxarrowinupright", "box-arrow-in-up-right" },
			{ "boxarrowinup", "box-arrow-in-up" },
			{ "boxarrowleft", "box-arrow-left" },
			{ "boxarrowright", "box-arrow-right" },
			{ "boxarrowupleft", "box-arrow-up-left" },
			{ "boxarrowupright", "box-arrow-up-right" },
			{ "boxarrowup", "box-arrow-up" },
			{ "boxseam", "box-seam" },
			{ "box", "box" },
			{ "braces", "braces" },
			{ "bricks", "bricks" },
			{ "briefcasefill", "briefcase-fill" },
			{ "briefcase", "briefcase" },
			{ "brightnessalthighfill", "brightness-alt-high-fill" },
			{ "brightnessalthigh", "brightness-alt-high" },
			{ "brightnessaltlowfill", "brightness-alt-low-fill" },
			{ "brightnessaltlow", "brightness-alt-low" },
			{ "brightnesshighfill", "brightness-high-fill" },
			{ "brightnesshigh", "brightness-high" },
			{ "brightnesslowfill", "brightness-low-fill" },
			{ "brightnesslow", "brightness-low" },
			{ "broadcastpin", "broadcast-pin" },
			{ "broadcast", "broadcast" },
			{ "brushfill", "brush-fill" },
			{ "brush", "brush" },
			{ "bucketfill", "bucket-fill" },
			{ "bucket", "bucket" },
			{ "bugfill", "bug-fill" },
			{ "bug", "bug" },
			{ "building", "building" },
			{ "bullseye", "bullseye" },
			{ "calculatorfill", "calculator-fill" },
			{ "calculator", "calculator" },
			{ "calendarcheckfill", "calendar-check-fill" },
			{ "calendarcheck", "calendar-check" },
			{ "calendardatefill", "calendar-date-fill" },
			{ "calendardate", "calendar-date" },
			{ "calendardayfill", "calendar-day-fill" },
			{ "calendarday", "calendar-day" },
			{ "calendareventfill", "calendar-event-fill" },
			{ "calendarevent", "calendar-event" },
			{ "calendarfill", "calendar-fill" },
			{ "calendarminusfill", "calendar-minus-fill" },
			{ "calendarminus", "calendar-minus" },
			{ "calendarmonthfill", "calendar-month-fill" },
			{ "calendarmonth", "calendar-month" },
			{ "calendarplusfill", "calendar-plus-fill" },
			{ "calendarplus", "calendar-plus" },
			{ "calendarrangefill", "calendar-range-fill" },
			{ "calendarrange", "calendar-range" },
			{ "calendarweekfill", "calendar-week-fill" },
			{ "calendarweek", "calendar-week" },
			{ "calendarxfill", "calendar-x-fill" },
			{ "calendarx", "calendar-x" },
			{ "calendar", "calendar" },
			{ "calendardoscheckfill", "calendar2-check-fill" },
			{ "calendardoscheck", "calendar2-check" },
			{ "calendardosdatefill", "calendar2-date-fill" },
			{ "calendardosdate", "calendar2-date" },
			{ "calendardosdayfill", "calendar2-day-fill" },
			{ "calendardosday", "calendar2-day" },
			{ "calendardoseventfill", "calendar2-event-fill" },
			{ "calendardosevent", "calendar2-event" },
			{ "calendardosfill", "calendar2-fill" },
			{ "calendardosminusfill", "calendar2-minus-fill" },
			{ "calendardosminus", "calendar2-minus" },
			{ "calendardosmonthfill", "calendar2-month-fill" },
			{ "calendardosmonth", "calendar2-month" },
			{ "calendardosplusfill", "calendar2-plus-fill" },
			{ "calendardosplus", "calendar2-plus" },
			{ "calendardosrangefill", "calendar2-range-fill" },
			{ "calendardosrange", "calendar2-range" },
			{ "calendardosweekfill", "calendar2-week-fill" },
			{ "calendardosweek", "calendar2-week" },
			{ "calendardosxfill", "calendar2-x-fill" },
			{ "calendardosx", "calendar2-x" },
			{ "calendardos", "calendar2" },
			{ "calendartreseventfill", "calendar3-event-fill" },
			{ "calendartresevent", "calendar3-event" },
			{ "calendartresfill", "calendar3-fill" },
			{ "calendartresrangefill", "calendar3-range-fill" },
			{ "calendartresrange", "calendar3-range" },
			{ "calendartresweekfill", "calendar3-week-fill" },
			{ "calendartresweek", "calendar3-week" },
			{ "calendartres", "calendar3" },
			{ "calendarcuatroevent", "calendar4-event" },
			{ "calendarcuatrorange", "calendar4-range" },
			{ "calendarcuatroweek", "calendar4-week" },
			{ "calendarcuatro", "calendar4" },
			{ "camerafill", "camera-fill" },
			{ "camerareelsfill", "camera-reels-fill" },
			{ "camerareels", "camera-reels" },
			{ "cameravideofill", "camera-video-fill" },
			{ "cameravideoofffill", "camera-video-off-fill" },
			{ "cameravideooff", "camera-video-off" },
			{ "cameravideo", "camera-video" },
			{ "camera", "camera" },
			{ "camerados", "camera2" },
			{ "capslockfill", "capslock-fill" },
			{ "capslock", "capslock" },
			{ "cardchecklist", "card-checklist" },
			{ "cardheading", "card-heading" },
			{ "cardimage", "card-image" },
			{ "cardlist", "card-list" },
			{ "cardtext", "card-text" },
			{ "caretdownfill", "caret-down-fill" },
			{ "caretdownsquarefill", "caret-down-square-fill" },
			{ "caretdownsquare", "caret-down-square" },
			{ "caretdown", "caret-down" },
			{ "caretleftfill", "caret-left-fill" },
			{ "caretleftsquarefill", "caret-left-square-fill" },
			{ "caretleftsquare", "caret-left-square" },
			{ "caretleft", "caret-left" },
			{ "caretrightfill", "caret-right-fill" },
			{ "caretrightsquarefill", "caret-right-square-fill" },
			{ "caretrightsquare", "caret-right-square" },
			{ "caretright", "caret-right" },
			{ "caretupfill", "caret-up-fill" },
			{ "caretupsquarefill", "caret-up-square-fill" },
			{ "caretupsquare", "caret-up-square" },
			{ "caretup", "caret-up" },
			{ "cartcheckfill", "cart-check-fill" },
			{ "cartcheck", "cart-check" },
			{ "cartdashfill", "cart-dash-fill" },
			{ "cartdash", "cart-dash" },
			{ "cartfill", "cart-fill" },
			{ "cartplusfill", "cart-plus-fill" },
			{ "cartplus", "cart-plus" },
			{ "cartxfill", "cart-x-fill" },
			{ "cartx", "cart-x" },
			{ "cart", "cart" },
			{ "cartdos", "cart2" },
			{ "carttres", "cart3" },
			{ "cartcuatro", "cart4" },
			{ "cashstack", "cash-stack" },
			{ "cash", "cash" },
			{ "cast", "cast" },
			{ "chatdotsfill", "chat-dots-fill" },
			{ "chatdots", "chat-dots" },
			{ "chatfill", "chat-fill" },
			{ "chatleftdotsfill", "chat-left-dots-fill" },
			{ "chatleftdots", "chat-left-dots" },
			{ "chatleftfill", "chat-left-fill" },
			{ "chatleftquotefill", "chat-left-quote-fill" },
			{ "chatleftquote", "chat-left-quote" },
			{ "chatlefttextfill", "chat-left-text-fill" },
			{ "chatlefttext", "chat-left-text" },
			{ "chatleft", "chat-left" },
			{ "chatquotefill", "chat-quote-fill" },
			{ "chatquote", "chat-quote" },
			{ "chatrightdotsfill", "chat-right-dots-fill" },
			{ "chatrightdots", "chat-right-dots" },
			{ "chatrightfill", "chat-right-fill" },
			{ "chatrightquotefill", "chat-right-quote-fill" },
			{ "chatrightquote", "chat-right-quote" },
			{ "chatrighttextfill", "chat-right-text-fill" },
			{ "chatrighttext", "chat-right-text" },
			{ "chatright", "chat-right" },
			{ "chatsquaredotsfill", "chat-square-dots-fill" },
			{ "chatsquaredots", "chat-square-dots" },
			{ "chatsquarefill", "chat-square-fill" },
			{ "chatsquarequotefill", "chat-square-quote-fill" },
			{ "chatsquarequote", "chat-square-quote" },
			{ "chatsquaretextfill", "chat-square-text-fill" },
			{ "chatsquaretext", "chat-square-text" },
			{ "chatsquare", "chat-square" },
			{ "chattextfill", "chat-text-fill" },
			{ "chattext", "chat-text" },
			{ "chat", "chat" },
			{ "checkall", "check-all" },
			{ "checkcirclefill", "check-circle-fill" },
			{ "checkcircle", "check-circle" },
			{ "checksquarefill", "check-square-fill" },
			{ "checksquare", "check-square" },
			{ "check", "check" },
			{ "checkdosall", "check2-all" },
			{ "checkdoscircle", "check2-circle" },
			{ "checkdossquare", "check2-square" },
			{ "checkdos", "check2" },
			{ "chevronbarcontract", "chevron-bar-contract" },
			{ "chevronbardown", "chevron-bar-down" },
			{ "chevronbarexpand", "chevron-bar-expand" },
			{ "chevronbarleft", "chevron-bar-left" },
			{ "chevronbarright", "chevron-bar-right" },
			{ "chevronbarup", "chevron-bar-up" },
			{ "chevroncompactdown", "chevron-compact-down" },
			{ "chevroncompactleft", "chevron-compact-left" },
			{ "chevroncompactright", "chevron-compact-right" },
			{ "chevroncompactup", "chevron-compact-up" },
			{ "chevroncontract", "chevron-contract" },
			{ "chevrondoubledown", "chevron-double-down" },
			{ "chevrondoubleleft", "chevron-double-left" },
			{ "chevrondoubleright", "chevron-double-right" },
			{ "chevrondoubleup", "chevron-double-up" },
			{ "chevrondown", "chevron-down" },
			{ "chevronexpand", "chevron-expand" },
			{ "chevronleft", "chevron-left" },
			{ "chevronright", "chevron-right" },
			{ "chevronup", "chevron-up" },
			{ "circlefill", "circle-fill" },
			{ "circlehalf", "circle-half" },
			{ "circlesquare", "circle-square" },
			{ "circle", "circle" },
			{ "clipboardcheck", "clipboard-check" },
			{ "clipboarddata", "clipboard-data" },
			{ "clipboardminus", "clipboard-minus" },
			{ "clipboardplus", "clipboard-plus" },
			{ "clipboardx", "clipboard-x" },
			{ "clipboard", "clipboard" },
			{ "clockfill", "clock-fill" },
			{ "clockhistory", "clock-history" },
			{ "clock", "clock" },
			{ "cloudarrowdownfill", "cloud-arrow-down-fill" },
			{ "cloudarrowdown", "cloud-arrow-down" },
			{ "cloudarrowupfill", "cloud-arrow-up-fill" },
			{ "cloudarrowup", "cloud-arrow-up" },
			{ "cloudcheckfill", "cloud-check-fill" },
			{ "cloudcheck", "cloud-check" },
			{ "clouddownloadfill", "cloud-download-fill" },
			{ "clouddownload", "cloud-download" },
			{ "clouddrizzlefill", "cloud-drizzle-fill" },
			{ "clouddrizzle", "cloud-drizzle" },
			{ "cloudfill", "cloud-fill" },
			{ "cloudfogfill", "cloud-fog-fill" },
			{ "cloudfog", "cloud-fog" },
			{ "cloudfogdosfill", "cloud-fog2-fill" },
			{ "cloudfogdos", "cloud-fog2" },
			{ "cloudhailfill", "cloud-hail-fill" },
			{ "cloudhail", "cloud-hail" },
			{ "cloudhazefill", "cloud-haze-fill" },
			{ "cloudhaze", "cloud-haze" },
			{ "cloudhazedosfill", "cloud-haze2-fill" },
			{ "cloudlightningfill", "cloud-lightning-fill" },
			{ "cloudlightningrainfill", "cloud-lightning-rain-fill" },
			{ "cloudlightningrain", "cloud-lightning-rain" },
			{ "cloudlightning", "cloud-lightning" },
			{ "cloudminusfill", "cloud-minus-fill" },
			{ "cloudminus", "cloud-minus" },
			{ "cloudmoonfill", "cloud-moon-fill" },
			{ "cloudmoon", "cloud-moon" },
			{ "cloudplusfill", "cloud-plus-fill" },
			{ "cloudplus", "cloud-plus" },
			{ "cloudrainfill", "cloud-rain-fill" },
			{ "cloudrainheavyfill", "cloud-rain-heavy-fill" },
			{ "cloudrainheavy", "cloud-rain-heavy" },
			{ "cloudrain", "cloud-rain" },
			{ "cloudslashfill", "cloud-slash-fill" },
			{ "cloudslash", "cloud-slash" },
			{ "cloudsleetfill", "cloud-sleet-fill" },
			{ "cloudsleet", "cloud-sleet" },
			{ "cloudsnowfill", "cloud-snow-fill" },
			{ "cloudsnow", "cloud-snow" },
			{ "cloudsunfill", "cloud-sun-fill" },
			{ "cloudsun", "cloud-sun" },
			{ "clouduploadfill", "cloud-upload-fill" },
			{ "cloudupload", "cloud-upload" },
			{ "cloud", "cloud" },
			{ "cloudsfill", "clouds-fill" },
			{ "clouds", "clouds" },
			{ "cloudyfill", "cloudy-fill" },
			{ "cloudy", "cloudy" },
			{ "codeslash", "code-slash" },
			{ "codesquare", "code-square" },
			{ "code", "code" },
			{ "collectionfill", "collection-fill" },
			{ "collectionplayfill", "collection-play-fill" },
			{ "collectionplay", "collection-play" },
			{ "collection", "collection" },
			{ "columnsgap", "columns-gap" },
			{ "columns", "columns" },
			{ "command", "command" },
			{ "compassfill", "compass-fill" },
			{ "compass", "compass" },
			{ "conestriped", "cone-striped" },
			{ "cone", "cone" },
			{ "controller", "controller" },
			{ "cpufill", "cpu-fill" },
			{ "cpu", "cpu" },
			{ "creditcarddosbackfill", "credit-card-2-back-fill" },
			{ "creditcarddosback", "credit-card-2-back" },
			{ "creditcarddosfrontfill", "credit-card-2-front-fill" },
			{ "creditcarddosfront", "credit-card-2-front" },
			{ "creditcardfill", "credit-card-fill" },
			{ "creditcard", "credit-card" },
			{ "crop", "crop" },
			{ "cupfill", "cup-fill" },
			{ "cupstraw", "cup-straw" },
			{ "cup", "cup" },
			{ "cursorfill", "cursor-fill" },
			{ "cursortext", "cursor-text" },
			{ "cursor", "cursor" },
			{ "dashcircledotted", "dash-circle-dotted" },
			{ "dashcirclefill", "dash-circle-fill" },
			{ "dashcircle", "dash-circle" },
			{ "dashsquaredotted", "dash-square-dotted" },
			{ "dashsquarefill", "dash-square-fill" },
			{ "dashsquare", "dash-square" },
			{ "dash", "dash" },
			{ "diagramdosfill", "diagram-2-fill" },
			{ "diagramdos", "diagram-2" },
			{ "diagramtresfill", "diagram-3-fill" },
			{ "diagramtres", "diagram-3" },
			{ "diamondfill", "diamond-fill" },
			{ "diamondhalf", "diamond-half" },
			{ "diamond", "diamond" },
			{ "diceunofill", "dice-1-fill" },
			{ "diceuno", "dice-1" },
			{ "dicedosfill", "dice-2-fill" },
			{ "dicedos", "dice-2" },
			{ "dicetresfill", "dice-3-fill" },
			{ "dicetres", "dice-3" },
			{ "dicecuatrofill", "dice-4-fill" },
			{ "dicecuatro", "dice-4" },
			{ "dicecincofill", "dice-5-fill" },
			{ "dicecinco", "dice-5" },
			{ "diceseisfill", "dice-6-fill" },
			{ "diceseis", "dice-6" },
			{ "discfill", "disc-fill" },
			{ "disc", "disc" },
			{ "discord", "discord" },
			{ "displayfill", "display-fill" },
			{ "display", "display" },
			{ "distributehorizontal", "distribute-horizontal" },
			{ "distributevertical", "distribute-vertical" },
			{ "doorclosedfill", "door-closed-fill" },
			{ "doorclosed", "door-closed" },
			{ "dooropenfill", "door-open-fill" },
			{ "dooropen", "door-open" },
			{ "dot", "dot" },
			{ "download", "download" },
			{ "dropletfill", "droplet-fill" },
			{ "droplethalf", "droplet-half" },
			{ "droplet", "droplet" },
			{ "earbuds", "earbuds" },
			{ "easelfill", "easel-fill" },
			{ "easel", "easel" },
			{ "eggfill", "egg-fill" },
			{ "eggfried", "egg-fried" },
			{ "egg", "egg" },
			{ "ejectfill", "eject-fill" },
			{ "eject", "eject" },
			{ "emojiangryfill", "emoji-angry-fill" },
			{ "emojiangry", "emoji-angry" },
			{ "emojidizzyfill", "emoji-dizzy-fill" },
			{ "emojidizzy", "emoji-dizzy" },
			{ "emojiexpressionlessfill", "emoji-expressionless-fill" },
			{ "emojiexpressionless", "emoji-expressionless" },
			{ "emojifrownfill", "emoji-frown-fill" },
			{ "emojifrown", "emoji-frown" },
			{ "emojihearteyesfill", "emoji-heart-eyes-fill" },
			{ "emojihearteyes", "emoji-heart-eyes" },
			{ "emojilaughingfill", "emoji-laughing-fill" },
			{ "emojilaughing", "emoji-laughing" },
			{ "emojineutralfill", "emoji-neutral-fill" },
			{ "emojineutral", "emoji-neutral" },
			{ "emojismilefill", "emoji-smile-fill" },
			{ "emojismileupsidedownfill", "emoji-smile-upside-down-fill" },
			{ "emojismileupsidedown", "emoji-smile-upside-down" },
			{ "emojismile", "emoji-smile" },
			{ "emojisunglassesfill", "emoji-sunglasses-fill" },
			{ "emojisunglasses", "emoji-sunglasses" },
			{ "emojiwinkfill", "emoji-wink-fill" },
			{ "emojiwink", "emoji-wink" },
			{ "envelopefill", "envelope-fill" },
			{ "envelopeopenfill", "envelope-open-fill" },
			{ "envelopeopen", "envelope-open" },
			{ "envelope", "envelope" },
			{ "eraserfill", "eraser-fill" },
			{ "eraser", "eraser" },
			{ "exclamationcirclefill", "exclamation-circle-fill" },
			{ "exclamationcircle", "exclamation-circle" },
			{ "exclamationdiamondfill", "exclamation-diamond-fill" },
			{ "exclamationdiamond", "exclamation-diamond" },
			{ "exclamationoctagonfill", "exclamation-octagon-fill" },
			{ "exclamationoctagon", "exclamation-octagon" },
			{ "exclamationsquarefill", "exclamation-square-fill" },
			{ "exclamationsquare", "exclamation-square" },
			{ "exclamationtrianglefill", "exclamation-triangle-fill" },
			{ "exclamationtriangle", "exclamation-triangle" },
			{ "exclamation", "exclamation" },
			{ "exclude", "exclude" },
			{ "eyefill", "eye-fill" },
			{ "eyeslashfill", "eye-slash-fill" },
			{ "eyeslash", "eye-slash" },
			{ "eye", "eye" },
			{ "eyedropper", "eyedropper" },
			{ "eyeglasses", "eyeglasses" },
			{ "facebook", "facebook" },
			{ "filearrowdownfill", "file-arrow-down-fill" },
			{ "filearrowdown", "file-arrow-down" },
			{ "filearrowupfill", "file-arrow-up-fill" },
			{ "filearrowup", "file-arrow-up" },
			{ "filebargraphfill", "file-bar-graph-fill" },
			{ "filebargraph", "file-bar-graph" },
			{ "filebinaryfill", "file-binary-fill" },
			{ "filebinary", "file-binary" },
			{ "filebreakfill", "file-break-fill" },
			{ "filebreak", "file-break" },
			{ "filecheckfill", "file-check-fill" },
			{ "filecheck", "file-check" },
			{ "filecodefill", "file-code-fill" },
			{ "filecode", "file-code" },
			{ "filedifffill", "file-diff-fill" },
			{ "filediff", "file-diff" },
			{ "fileearmarkarrowdownfill", "file-earmark-arrow-down-fill" },
			{ "fileearmarkarrowdown", "file-earmark-arrow-down" },
			{ "fileearmarkarrowupfill", "file-earmark-arrow-up-fill" },
			{ "fileearmarkarrowup", "file-earmark-arrow-up" },
			{ "fileearmarkbargraphfill", "file-earmark-bar-graph-fill" },
			{ "fileearmarkbargraph", "file-earmark-bar-graph" },
			{ "fileearmarkbinaryfill", "file-earmark-binary-fill" },
			{ "fileearmarkbinary", "file-earmark-binary" },
			{ "fileearmarkbreakfill", "file-earmark-break-fill" },
			{ "fileearmarkbreak", "file-earmark-break" },
			{ "fileearmarkcheckfill", "file-earmark-check-fill" },
			{ "fileearmarkcheck", "file-earmark-check" },
			{ "fileearmarkcodefill", "file-earmark-code-fill" },
			{ "fileearmarkcode", "file-earmark-code" },
			{ "fileearmarkdifffill", "file-earmark-diff-fill" },
			{ "fileearmarkdiff", "file-earmark-diff" },
			{ "fileearmarkeaselfill", "file-earmark-easel-fill" },
			{ "fileearmarkeasel", "file-earmark-easel" },
			{ "fileearmarkexcelfill", "file-earmark-excel-fill" },
			{ "fileearmarkexcel", "file-earmark-excel" },
			{ "fileearmarkfill", "file-earmark-fill" },
			{ "fileearmarkfontfill", "file-earmark-font-fill" },
			{ "fileearmarkfont", "file-earmark-font" },
			{ "fileearmarkimagefill", "file-earmark-image-fill" },
			{ "fileearmarkimage", "file-earmark-image" },
			{ "fileearmarklockfill", "file-earmark-lock-fill" },
			{ "fileearmarklock", "file-earmark-lock" },
			{ "fileearmarklockdosfill", "file-earmark-lock2-fill" },
			{ "fileearmarklockdos", "file-earmark-lock2" },
			{ "fileearmarkmedicalfill", "file-earmark-medical-fill" },
			{ "fileearmarkmedical", "file-earmark-medical" },
			{ "fileearmarkminusfill", "file-earmark-minus-fill" },
			{ "fileearmarkminus", "file-earmark-minus" },
			{ "fileearmarkmusicfill", "file-earmark-music-fill" },
			{ "fileearmarkmusic", "file-earmark-music" },
			{ "fileearmarkpersonfill", "file-earmark-person-fill" },
			{ "fileearmarkperson", "file-earmark-person" },
			{ "fileearmarkplayfill", "file-earmark-play-fill" },
			{ "fileearmarkplay", "file-earmark-play" },
			{ "fileearmarkplusfill", "file-earmark-plus-fill" },
			{ "fileearmarkplus", "file-earmark-plus" },
			{ "fileearmarkpostfill", "file-earmark-post-fill" },
			{ "fileearmarkpost", "file-earmark-post" },
			{ "fileearmarkpptfill", "file-earmark-ppt-fill" },
			{ "fileearmarkppt", "file-earmark-ppt" },
			{ "fileearmarkrichtextfill", "file-earmark-richtext-fill" },
			{ "fileearmarkrichtext", "file-earmark-richtext" },
			{ "fileearmarkruledfill", "file-earmark-ruled-fill" },
			{ "fileearmarkruled", "file-earmark-ruled" },
			{ "fileearmarkslidesfill", "file-earmark-slides-fill" },
			{ "fileearmarkslides", "file-earmark-slides" },
			{ "fileearmarkspreadsheetfill", "file-earmark-spreadsheet-fill" },
			{ "fileearmarkspreadsheet", "file-earmark-spreadsheet" },
			{ "fileearmarktextfill", "file-earmark-text-fill" },
			{ "fileearmarktext", "file-earmark-text" },
			{ "fileearmarkwordfill", "file-earmark-word-fill" },
			{ "fileearmarkword", "file-earmark-word" },
			{ "fileearmarkxfill", "file-earmark-x-fill" },
			{ "fileearmarkx", "file-earmark-x" },
			{ "fileearmarkzipfill", "file-earmark-zip-fill" },
			{ "fileearmarkzip", "file-earmark-zip" },
			{ "fileearmark", "file-earmark" },
			{ "fileeaselfill", "file-easel-fill" },
			{ "fileeasel", "file-easel" },
			{ "fileexcelfill", "file-excel-fill" },
			{ "fileexcel", "file-excel" },
			{ "filefill", "file-fill" },
			{ "filefontfill", "file-font-fill" },
			{ "filefont", "file-font" },
			{ "fileimagefill", "file-image-fill" },
			{ "fileimage", "file-image" },
			{ "filelockfill", "file-lock-fill" },
			{ "filelock", "file-lock" },
			{ "filelockdosfill", "file-lock2-fill" },
			{ "filelockdos", "file-lock2" },
			{ "filemedicalfill", "file-medical-fill" },
			{ "filemedical", "file-medical" },
			{ "fileminusfill", "file-minus-fill" },
			{ "fileminus", "file-minus" },
			{ "filemusicfill", "file-music-fill" },
			{ "filemusic", "file-music" },
			{ "filepersonfill", "file-person-fill" },
			{ "fileperson", "file-person" },
			{ "fileplayfill", "file-play-fill" },
			{ "fileplay", "file-play" },
			{ "fileplusfill", "file-plus-fill" },
			{ "fileplus", "file-plus" },
			{ "filepostfill", "file-post-fill" },
			{ "filepost", "file-post" },
			{ "filepptfill", "file-ppt-fill" },
			{ "fileppt", "file-ppt" },
			{ "filerichtextfill", "file-richtext-fill" },
			{ "filerichtext", "file-richtext" },
			{ "fileruledfill", "file-ruled-fill" },
			{ "fileruled", "file-ruled" },
			{ "fileslidesfill", "file-slides-fill" },
			{ "fileslides", "file-slides" },
			{ "filespreadsheetfill", "file-spreadsheet-fill" },
			{ "filespreadsheet", "file-spreadsheet" },
			{ "filetextfill", "file-text-fill" },
			{ "filetext", "file-text" },
			{ "filewordfill", "file-word-fill" },
			{ "fileword", "file-word" },
			{ "filexfill", "file-x-fill" },
			{ "filex", "file-x" },
			{ "filezipfill", "file-zip-fill" },
			{ "filezip", "file-zip" },
			{ "file", "file" },
			{ "filesalt", "files-alt" },
			{ "files", "files" },
			{ "film", "film" },
			{ "filtercirclefill", "filter-circle-fill" },
			{ "filtercircle", "filter-circle" },
			{ "filterleft", "filter-left" },
			{ "filterright", "filter-right" },
			{ "filtersquarefill", "filter-square-fill" },
			{ "filtersquare", "filter-square" },
			{ "filter", "filter" },
			{ "flagfill", "flag-fill" },
			{ "flag", "flag" },
			{ "floweruno", "flower1" },
			{ "flowerdos", "flower2" },
			{ "flowertres", "flower3" },
			{ "foldercheck", "folder-check" },
			{ "folderfill", "folder-fill" },
			{ "folderminus", "folder-minus" },
			{ "folderplus", "folder-plus" },
			{ "foldersymlinkfill", "folder-symlink-fill" },
			{ "foldersymlink", "folder-symlink" },
			{ "folderx", "folder-x" },
			{ "folder", "folder" },
			{ "folderdosopen", "folder2-open" },
			{ "folderdos", "folder2" },
			{ "fonts", "fonts" },
			{ "forwardfill", "forward-fill" },
			{ "forward", "forward" },
			{ "front", "front" },
			{ "fullscreenexit", "fullscreen-exit" },
			{ "fullscreen", "fullscreen" },
			{ "funnelfill", "funnel-fill" },
			{ "funnel", "funnel" },
			{ "gearfill", "gear-fill" },
			{ "gearwideconnected", "gear-wide-connected" },
			{ "gearwide", "gear-wide" },
			{ "gear", "gear" },
			{ "gem", "gem" },
			{ "geoaltfill", "geo-alt-fill" },
			{ "geoalt", "geo-alt" },
			{ "geofill", "geo-fill" },
			{ "geo", "geo" },
			{ "giftfill", "gift-fill" },
			{ "gift", "gift" },
			{ "github", "github" },
			{ "globe", "globe" },
			{ "globedos", "globe2" },
			{ "google", "google" },
			{ "graphdown", "graph-down" },
			{ "graphup", "graph-up" },
			{ "gridunoxdosfill", "grid-1x2-fill" },
			{ "gridunoxdos", "grid-1x2" },
			{ "gridtresxdosgapfill", "grid-3x2-gap-fill" },
			{ "gridtresxdosgap", "grid-3x2-gap" },
			{ "gridtresxdos", "grid-3x2" },
			{ "gridtresxtresgapfill", "grid-3x3-gap-fill" },
			{ "gridtresxtresgap", "grid-3x3-gap" },
			{ "gridtresxtres", "grid-3x3" },
			{ "gridfill", "grid-fill" },
			{ "grid", "grid" },
			{ "griphorizontal", "grip-horizontal" },
			{ "gripvertical", "grip-vertical" },
			{ "hammer", "hammer" },
			{ "handindexfill", "hand-index-fill" },
			{ "handindexthumbfill", "hand-index-thumb-fill" },
			{ "handindexthumb", "hand-index-thumb" },
			{ "handindex", "hand-index" },
			{ "handthumbsdownfill", "hand-thumbs-down-fill" },
			{ "handthumbsdown", "hand-thumbs-down" },
			{ "handthumbsupfill", "hand-thumbs-up-fill" },
			{ "handthumbsup", "hand-thumbs-up" },
			{ "handbagfill", "handbag-fill" },
			{ "handbag", "handbag" },
			{ "hash", "hash" },
			{ "hddfill", "hdd-fill" },
			{ "hddnetworkfill", "hdd-network-fill" },
			{ "hddnetwork", "hdd-network" },
			{ "hddrackfill", "hdd-rack-fill" },
			{ "hddrack", "hdd-rack" },
			{ "hddstackfill", "hdd-stack-fill" },
			{ "hddstack", "hdd-stack" },
			{ "hdd", "hdd" },
			{ "headphones", "headphones" },
			{ "headset", "headset" },
			{ "heartfill", "heart-fill" },
			{ "hearthalf", "heart-half" },
			{ "heart", "heart" },
			{ "heptagonfill", "heptagon-fill" },
			{ "heptagonhalf", "heptagon-half" },
			{ "heptagon", "heptagon" },
			{ "hexagonfill", "hexagon-fill" },
			{ "hexagonhalf", "hexagon-half" },
			{ "hexagon", "hexagon" },
			{ "hourglassbottom", "hourglass-bottom" },
			{ "hourglasssplit", "hourglass-split" },
			{ "hourglasstop", "hourglass-top" },
			{ "hourglass", "hourglass" },
			{ "housedoorfill", "house-door-fill" },
			{ "housedoor", "house-door" },
			{ "housefill", "house-fill" },
			{ "house", "house" },
			{ "hr", "hr" },
			{ "hurricane", "hurricane" },
			{ "imagealt", "image-alt" },
			{ "imagefill", "image-fill" },
			{ "image", "image" },
			{ "images", "images" },
			{ "inboxfill", "inbox-fill" },
			{ "inbox", "inbox" },
			{ "inboxesfill", "inboxes-fill" },
			{ "inboxes", "inboxes" },
			{ "infocirclefill", "info-circle-fill" },
			{ "infocircle", "info-circle" },
			{ "infosquarefill", "info-square-fill" },
			{ "infosquare", "info-square" },
			{ "info", "info" },
			{ "inputcursortext", "input-cursor-text" },
			{ "inputcursor", "input-cursor" },
			{ "instagram", "instagram" },
			{ "intersect", "intersect" },
			{ "journalalbum", "journal-album" },
			{ "journalarrowdown", "journal-arrow-down" },
			{ "journalarrowup", "journal-arrow-up" },
			{ "journalbookmarkfill", "journal-bookmark-fill" },
			{ "journalbookmark", "journal-bookmark" },
			{ "journalcheck", "journal-check" },
			{ "journalcode", "journal-code" },
			{ "journalmedical", "journal-medical" },
			{ "journalminus", "journal-minus" },
			{ "journalplus", "journal-plus" },
			{ "journalrichtext", "journal-richtext" },
			{ "journaltext", "journal-text" },
			{ "journalx", "journal-x" },
			{ "journal", "journal" },
			{ "journals", "journals" },
			{ "joystick", "joystick" },
			{ "justifyleft", "justify-left" },
			{ "justifyright", "justify-right" },
			{ "justify", "justify" },
			{ "kanbanfill", "kanban-fill" },
			{ "kanban", "kanban" },
			{ "keyfill", "key-fill" },
			{ "key", "key" },
			{ "keyboardfill", "keyboard-fill" },
			{ "keyboard", "keyboard" },
			{ "ladder", "ladder" },
			{ "lampfill", "lamp-fill" },
			{ "lamp", "lamp" },
			{ "laptopfill", "laptop-fill" },
			{ "laptop", "laptop" },
			{ "layerbackward", "layer-backward" },
			{ "layerforward", "layer-forward" },
			{ "layersfill", "layers-fill" },
			{ "layershalf", "layers-half" },
			{ "layers", "layers" },
			{ "layoutsidebarinsetreverse", "layout-sidebar-inset-reverse" },
			{ "layoutsidebarinset", "layout-sidebar-inset" },
			{ "layoutsidebarreverse", "layout-sidebar-reverse" },
			{ "layoutsidebar", "layout-sidebar" },
			{ "layoutsplit", "layout-split" },
			{ "layouttextsidebarreverse", "layout-text-sidebar-reverse" },
			{ "layouttextsidebar", "layout-text-sidebar" },
			{ "layouttextwindowreverse", "layout-text-window-reverse" },
			{ "layouttextwindow", "layout-text-window" },
			{ "layoutthreecolumns", "layout-three-columns" },
			{ "layoutwtf", "layout-wtf" },
			{ "lifepreserver", "life-preserver" },
			{ "lightbulbfill", "lightbulb-fill" },
			{ "lightbulbofffill", "lightbulb-off-fill" },
			{ "lightbulboff", "lightbulb-off" },
			{ "lightbulb", "lightbulb" },
			{ "lightningchargefill", "lightning-charge-fill" },
			{ "lightningcharge", "lightning-charge" },
			{ "lightningfill", "lightning-fill" },
			{ "lightning", "lightning" },
			{ "linkcuatrocincodeg", "link-45deg" },
			{ "link", "link" },
			{ "linkedin", "linkedin" },
			{ "listcheck", "list-check" },
			{ "listnested", "list-nested" },
			{ "listol", "list-ol" },
			{ "liststars", "list-stars" },
			{ "listtask", "list-task" },
			{ "listul", "list-ul" },
			{ "list", "list" },
			{ "lockfill", "lock-fill" },
			{ "lock", "lock" },
			{ "mailbox", "mailbox" },
			{ "mailboxdos", "mailbox2" },
			{ "mapfill", "map-fill" },
			{ "map", "map" },
			{ "markdownfill", "markdown-fill" },
			{ "markdown", "markdown" },
			{ "mask", "mask" },
			{ "megaphonefill", "megaphone-fill" },
			{ "megaphone", "megaphone" },
			{ "menuappfill", "menu-app-fill" },
			{ "menuapp", "menu-app" },
			{ "menubuttonfill", "menu-button-fill" },
			{ "menubuttonwidefill", "menu-button-wide-fill" },
			{ "menubuttonwide", "menu-button-wide" },
			{ "menubutton", "menu-button" },
			{ "menudown", "menu-down" },
			{ "menuup", "menu-up" },
			{ "micfill", "mic-fill" },
			{ "micmutefill", "mic-mute-fill" },
			{ "micmute", "mic-mute" },
			{ "mic", "mic" },
			{ "minecartloaded", "minecart-loaded" },
			{ "minecart", "minecart" },
			{ "moisture", "moisture" },
			{ "moonfill", "moon-fill" },
			{ "moonstarsfill", "moon-stars-fill" },
			{ "moonstars", "moon-stars" },
			{ "moon", "moon" },
			{ "mousefill", "mouse-fill" },
			{ "mouse", "mouse" },
			{ "mousedosfill", "mouse2-fill" },
			{ "mousedos", "mouse2" },
			{ "mousetresfill", "mouse3-fill" },
			{ "mousetres", "mouse3" },
			{ "musicnotebeamed", "music-note-beamed" },
			{ "musicnotelist", "music-note-list" },
			{ "musicnote", "music-note" },
			{ "musicplayerfill", "music-player-fill" },
			{ "musicplayer", "music-player" },
			{ "newspaper", "newspaper" },
			{ "nodeminusfill", "node-minus-fill" },
			{ "nodeminus", "node-minus" },
			{ "nodeplusfill", "node-plus-fill" },
			{ "nodeplus", "node-plus" },
			{ "nutfill", "nut-fill" },
			{ "nut", "nut" },
			{ "octagonfill", "octagon-fill" },
			{ "octagonhalf", "octagon-half" },
			{ "octagon", "octagon" },
			{ "option", "option" },
			{ "outlet", "outlet" },
			{ "paintbucket", "paint-bucket" },
			{ "palettefill", "palette-fill" },
			{ "palette", "palette" },
			{ "palettedos", "palette2" },
			{ "paperclip", "paperclip" },
			{ "paragraph", "paragraph" },
			{ "patchcheckfill", "patch-check-fill" },
			{ "patchcheck", "patch-check" },
			{ "patchexclamationfill", "patch-exclamation-fill" },
			{ "patchexclamation", "patch-exclamation" },
			{ "patchminusfill", "patch-minus-fill" },
			{ "patchminus", "patch-minus" },
			{ "patchplusfill", "patch-plus-fill" },
			{ "patchplus", "patch-plus" },
			{ "patchquestionfill", "patch-question-fill" },
			{ "patchquestion", "patch-question" },
			{ "pausebtnfill", "pause-btn-fill" },
			{ "pausebtn", "pause-btn" },
			{ "pausecirclefill", "pause-circle-fill" },
			{ "pausecircle", "pause-circle" },
			{ "pausefill", "pause-fill" },
			{ "pause", "pause" },
			{ "peacefill", "peace-fill" },
			{ "peace", "peace" },
			{ "penfill", "pen-fill" },
			{ "pen", "pen" },
			{ "pencilfill", "pencil-fill" },
			{ "pencilsquare", "pencil-square" },
			{ "pencil", "pencil" },
			{ "pentagonfill", "pentagon-fill" },
			{ "pentagonhalf", "pentagon-half" },
			{ "pentagon", "pentagon" },
			{ "peoplefill", "people-fill" },
			{ "people", "people" },
			{ "percent", "percent" },
			{ "personbadgefill", "person-badge-fill" },
			{ "personbadge", "person-badge" },
			{ "personboundingbox", "person-bounding-box" },
			{ "personcheckfill", "person-check-fill" },
			{ "personcheck", "person-check" },
			{ "personcircle", "person-circle" },
			{ "persondashfill", "person-dash-fill" },
			{ "persondash", "person-dash" },
			{ "personfill", "person-fill" },
			{ "personlinesfill", "person-lines-fill" },
			{ "personplusfill", "person-plus-fill" },
			{ "personplus", "person-plus" },
			{ "personsquare", "person-square" },
			{ "personxfill", "person-x-fill" },
			{ "personx", "person-x" },
			{ "person", "person" },
			{ "phonefill", "phone-fill" },
			{ "phonelandscapefill", "phone-landscape-fill" },
			{ "phonelandscape", "phone-landscape" },
			{ "phonevibratefill", "phone-vibrate-fill" },
			{ "phonevibrate", "phone-vibrate" },
			{ "phone", "phone" },
			{ "piechartfill", "pie-chart-fill" },
			{ "piechart", "pie-chart" },
			{ "pinanglefill", "pin-angle-fill" },
			{ "pinangle", "pin-angle" },
			{ "pinfill", "pin-fill" },
			{ "pin", "pin" },
			{ "pipfill", "pip-fill" },
			{ "pip", "pip" },
			{ "playbtnfill", "play-btn-fill" },
			{ "playbtn", "play-btn" },
			{ "playcirclefill", "play-circle-fill" },
			{ "playcircle", "play-circle" },
			{ "playfill", "play-fill" },
			{ "play", "play" },
			{ "plugfill", "plug-fill" },
			{ "plug", "plug" },
			{ "pluscircledotted", "plus-circle-dotted" },
			{ "pluscirclefill", "plus-circle-fill" },
			{ "pluscircle", "plus-circle" },
			{ "plussquaredotted", "plus-square-dotted" },
			{ "plussquarefill", "plus-square-fill" },
			{ "plussquare", "plus-square" },
			{ "plus", "plus" },
			{ "power", "power" },
			{ "printerfill", "printer-fill" },
			{ "printer", "printer" },
			{ "puzzlefill", "puzzle-fill" },
			{ "puzzle", "puzzle" },
			{ "questioncirclefill", "question-circle-fill" },
			{ "questioncircle", "question-circle" },
			{ "questiondiamondfill", "question-diamond-fill" },
			{ "questiondiamond", "question-diamond" },
			{ "questionoctagonfill", "question-octagon-fill" },
			{ "questionoctagon", "question-octagon" },
			{ "questionsquarefill", "question-square-fill" },
			{ "questionsquare", "question-square" },
			{ "question", "question" },
			{ "rainbow", "rainbow" },
			{ "receiptcutoff", "receipt-cutoff" },
			{ "receipt", "receipt" },
			{ "receptionzero", "reception-0" },
			{ "receptionuno", "reception-1" },
			{ "receptiondos", "reception-2" },
			{ "receptiontres", "reception-3" },
			{ "receptioncuatro", "reception-4" },
			{ "recordbtnfill", "record-btn-fill" },
			{ "recordbtn", "record-btn" },
			{ "recordcirclefill", "record-circle-fill" },
			{ "recordcircle", "record-circle" },
			{ "recordfill", "record-fill" },
			{ "record", "record" },
			{ "recorddosfill", "record2-fill" },
			{ "recorddos", "record2" },
			{ "replyallfill", "reply-all-fill" },
			{ "replyall", "reply-all" },
			{ "replyfill", "reply-fill" },
			{ "reply", "reply" },
			{ "rssfill", "rss-fill" },
			{ "rss", "rss" },
			{ "rulers", "rulers" },
			{ "savefill", "save-fill" },
			{ "save", "save" },
			{ "savedosfill", "save2-fill" },
			{ "savedos", "save2" },
			{ "scissors", "scissors" },
			{ "screwdriver", "screwdriver" },
			{ "search", "search" },
			{ "segmentednav", "segmented-nav" },
			{ "server", "server" },
			{ "sharefill", "share-fill" },
			{ "share", "share" },
			{ "shieldcheck", "shield-check" },
			{ "shieldexclamation", "shield-exclamation" },
			{ "shieldfillcheck", "shield-fill-check" },
			{ "shieldfillexclamation", "shield-fill-exclamation" },
			{ "shieldfillminus", "shield-fill-minus" },
			{ "shieldfillplus", "shield-fill-plus" },
			{ "shieldfillx", "shield-fill-x" },
			{ "shieldfill", "shield-fill" },
			{ "shieldlockfill", "shield-lock-fill" },
			{ "shieldlock", "shield-lock" },
			{ "shieldminus", "shield-minus" },
			{ "shieldplus", "shield-plus" },
			{ "shieldshaded", "shield-shaded" },
			{ "shieldslashfill", "shield-slash-fill" },
			{ "shieldslash", "shield-slash" },
			{ "shieldx", "shield-x" },
			{ "shield", "shield" },
			{ "shiftfill", "shift-fill" },
			{ "shift", "shift" },
			{ "shopwindow", "shop-window" },
			{ "shop", "shop" },
			{ "shuffle", "shuffle" },
			{ "signpostdosfill", "signpost-2-fill" },
			{ "signpostdos", "signpost-2" },
			{ "signpostfill", "signpost-fill" },
			{ "signpostsplitfill", "signpost-split-fill" },
			{ "signpostsplit", "signpost-split" },
			{ "signpost", "signpost" },
			{ "simfill", "sim-fill" },
			{ "sim", "sim" },
			{ "skipbackwardbtnfill", "skip-backward-btn-fill" },
			{ "skipbackwardbtn", "skip-backward-btn" },
			{ "skipbackwardcirclefill", "skip-backward-circle-fill" },
			{ "skipbackwardcircle", "skip-backward-circle" },
			{ "skipbackwardfill", "skip-backward-fill" },
			{ "skipbackward", "skip-backward" },
			{ "skipendbtnfill", "skip-end-btn-fill" },
			{ "skipendbtn", "skip-end-btn" },
			{ "skipendcirclefill", "skip-end-circle-fill" },
			{ "skipendcircle", "skip-end-circle" },
			{ "skipendfill", "skip-end-fill" },
			{ "skipend", "skip-end" },
			{ "skipforwardbtnfill", "skip-forward-btn-fill" },
			{ "skipforwardbtn", "skip-forward-btn" },
			{ "skipforwardcirclefill", "skip-forward-circle-fill" },
			{ "skipforwardcircle", "skip-forward-circle" },
			{ "skipforwardfill", "skip-forward-fill" },
			{ "skipforward", "skip-forward" },
			{ "skipstartbtnfill", "skip-start-btn-fill" },
			{ "skipstartbtn", "skip-start-btn" },
			{ "skipstartcirclefill", "skip-start-circle-fill" },
			{ "skipstartcircle", "skip-start-circle" },
			{ "skipstartfill", "skip-start-fill" },
			{ "skipstart", "skip-start" },
			{ "slack", "slack" },
			{ "slashcirclefill", "slash-circle-fill" },
			{ "slashcircle", "slash-circle" },
			{ "slashsquarefill", "slash-square-fill" },
			{ "slashsquare", "slash-square" },
			{ "slash", "slash" },
			{ "sliders", "sliders" },
			{ "smartwatch", "smartwatch" },
			{ "snow", "snow" },
			{ "snowdos", "snow2" },
			{ "snowtres", "snow3" },
			{ "sortalphadownalt", "sort-alpha-down-alt" },
			{ "sortalphadown", "sort-alpha-down" },
			{ "sortalphaupalt", "sort-alpha-up-alt" },
			{ "sortalphaup", "sort-alpha-up" },
			{ "sortdownalt", "sort-down-alt" },
			{ "sortdown", "sort-down" },
			{ "sortnumericdownalt", "sort-numeric-down-alt" },
			{ "sortnumericdown", "sort-numeric-down" },
			{ "sortnumericupalt", "sort-numeric-up-alt" },
			{ "sortnumericup", "sort-numeric-up" },
			{ "sortupalt", "sort-up-alt" },
			{ "sortup", "sort-up" },
			{ "soundwave", "soundwave" },
			{ "speakerfill", "speaker-fill" },
			{ "speaker", "speaker" },
			{ "speedometer", "speedometer" },
			{ "speedometerdos", "speedometer2" },
			{ "spellcheck", "spellcheck" },
			{ "squarefill", "square-fill" },
			{ "squarehalf", "square-half" },
			{ "square", "square" },
			{ "stack", "stack" },
			{ "starfill", "star-fill" },
			{ "starhalf", "star-half" },
			{ "star", "star" },
			{ "stars", "stars" },
			{ "stickiesfill", "stickies-fill" },
			{ "stickies", "stickies" },
			{ "stickyfill", "sticky-fill" },
			{ "sticky", "sticky" },
			{ "stopbtnfill", "stop-btn-fill" },
			{ "stopbtn", "stop-btn" },
			{ "stopcirclefill", "stop-circle-fill" },
			{ "stopcircle", "stop-circle" },
			{ "stopfill", "stop-fill" },
			{ "stop", "stop" },
			{ "stoplightsfill", "stoplights-fill" },
			{ "stoplights", "stoplights" },
			{ "stopwatchfill", "stopwatch-fill" },
			{ "stopwatch", "stopwatch" },
			{ "subtract", "subtract" },
			{ "suitclubfill", "suit-club-fill" },
			{ "suitclub", "suit-club" },
			{ "suitdiamondfill", "suit-diamond-fill" },
			{ "suitdiamond", "suit-diamond" },
			{ "suitheartfill", "suit-heart-fill" },
			{ "suitheart", "suit-heart" },
			{ "suitspadefill", "suit-spade-fill" },
			{ "suitspade", "suit-spade" },
			{ "sunfill", "sun-fill" },
			{ "sun", "sun" },
			{ "sunglasses", "sunglasses" },
			{ "sunrisefill", "sunrise-fill" },
			{ "sunrise", "sunrise" },
			{ "sunsetfill", "sunset-fill" },
			{ "sunset", "sunset" },
			{ "symmetryhorizontal", "symmetry-horizontal" },
			{ "symmetryvertical", "symmetry-vertical" },
			{ "table", "table" },
			{ "tabletfill", "tablet-fill" },
			{ "tabletlandscapefill", "tablet-landscape-fill" },
			{ "tabletlandscape", "tablet-landscape" },
			{ "tablet", "tablet" },
			{ "tagfill", "tag-fill" },
			{ "tag", "tag" },
			{ "tagsfill", "tags-fill" },
			{ "tags", "tags" },
			{ "telegram", "telegram" },
			{ "telephonefill", "telephone-fill" },
			{ "telephoneforwardfill", "telephone-forward-fill" },
			{ "telephoneforward", "telephone-forward" },
			{ "telephoneinboundfill", "telephone-inbound-fill" },
			{ "telephoneinbound", "telephone-inbound" },
			{ "telephoneminusfill", "telephone-minus-fill" },
			{ "telephoneminus", "telephone-minus" },
			{ "telephoneoutboundfill", "telephone-outbound-fill" },
			{ "telephoneoutbound", "telephone-outbound" },
			{ "telephoneplusfill", "telephone-plus-fill" },
			{ "telephoneplus", "telephone-plus" },
			{ "telephonexfill", "telephone-x-fill" },
			{ "telephonex", "telephone-x" },
			{ "telephone", "telephone" },
			{ "terminalfill", "terminal-fill" },
			{ "terminal", "terminal" },
			{ "textcenter", "text-center" },
			{ "textindentleft", "text-indent-left" },
			{ "textindentright", "text-indent-right" },
			{ "textleft", "text-left" },
			{ "textparagraph", "text-paragraph" },
			{ "textright", "text-right" },
			{ "textarearesize", "textarea-resize" },
			{ "textareat", "textarea-t" },
			{ "textarea", "textarea" },
			{ "thermometerhalf", "thermometer-half" },
			{ "thermometerhigh", "thermometer-high" },
			{ "thermometerlow", "thermometer-low" },
			{ "thermometersnow", "thermometer-snow" },
			{ "thermometersun", "thermometer-sun" },
			{ "thermometer", "thermometer" },
			{ "threedotsvertical", "three-dots-vertical" },
			{ "threedots", "three-dots" },
			{ "toggleoff", "toggle-off" },
			{ "toggleon", "toggle-on" },
			{ "toggledosoff", "toggle2-off" },
			{ "toggledoson", "toggle2-on" },
			{ "toggles", "toggles" },
			{ "togglesdos", "toggles2" },
			{ "tools", "tools" },
			{ "tornado", "tornado" },
			{ "trashfill", "trash-fill" },
			{ "trash", "trash" },
			{ "trashdosfill", "trash2-fill" },
			{ "trashdos", "trash2" },
			{ "treefill", "tree-fill" },
			{ "tree", "tree" },
			{ "trianglefill", "triangle-fill" },
			{ "trianglehalf", "triangle-half" },
			{ "triangle", "triangle" },
			{ "trophyfill", "trophy-fill" },
			{ "trophy", "trophy" },
			{ "tropicalstorm", "tropical-storm" },
			{ "truckflatbed", "truck-flatbed" },
			{ "truck", "truck" },
			{ "tsunami", "tsunami" },
			{ "tvfill", "tv-fill" },
			{ "tv", "tv" },
			{ "twitch", "twitch" },
			{ "twitter", "twitter" },
			{ "typebold", "type-bold" },
			{ "typehuno", "type-h1" },
			{ "typehdos", "type-h2" },
			{ "typehtres", "type-h3" },
			{ "typeitalic", "type-italic" },
			{ "typestrikethrough", "type-strikethrough" },
			{ "typeunderline", "type-underline" },
			{ "type", "type" },
			{ "uichecksgrid", "ui-checks-grid" },
			{ "uichecks", "ui-checks" },
			{ "uiradiosgrid", "ui-radios-grid" },
			{ "uiradios", "ui-radios" },
			{ "umbrellafill", "umbrella-fill" },
			{ "umbrella", "umbrella" },
			{ "union", "union" },
			{ "unlockfill", "unlock-fill" },
			{ "unlock", "unlock" },
			{ "upcscan", "upc-scan" },
			{ "upc", "upc" },
			{ "upload", "upload" },
			{ "vectorpen", "vector-pen" },
			{ "viewlist", "view-list" },
			{ "viewstacked", "view-stacked" },
			{ "vinylfill", "vinyl-fill" },
			{ "vinyl", "vinyl" },
			{ "voicemail", "voicemail" },
			{ "volumedownfill", "volume-down-fill" },
			{ "volumedown", "volume-down" },
			{ "volumemutefill", "volume-mute-fill" },
			{ "volumemute", "volume-mute" },
			{ "volumeofffill", "volume-off-fill" },
			{ "volumeoff", "volume-off" },
			{ "volumeupfill", "volume-up-fill" },
			{ "volumeup", "volume-up" },
			{ "vr", "vr" },
			{ "walletfill", "wallet-fill" },
			{ "wallet", "wallet" },
			{ "walletdos", "wallet2" },
			{ "watch", "watch" },
			{ "water", "water" },
			{ "whatsapp", "whatsapp" },
			{ "wifiuno", "wifi-1" },
			{ "wifidos", "wifi-2" },
			{ "wifioff", "wifi-off" },
			{ "wifi", "wifi" },
			{ "wind", "wind" },
			{ "windowdock", "window-dock" },
			{ "windowsidebar", "window-sidebar" },
			{ "window", "window" },
			{ "wrench", "wrench" },
			{ "xcirclefill", "x-circle-fill" },
			{ "xcircle", "x-circle" },
			{ "xdiamondfill", "x-diamond-fill" },
			{ "xdiamond", "x-diamond" },
			{ "xoctagonfill", "x-octagon-fill" },
			{ "xoctagon", "x-octagon" },
			{ "xsquarefill", "x-square-fill" },
			{ "xsquare", "x-square" },
			{ "x", "x" },
			{ "youtube", "youtube" },
			{ "zoomin", "zoom-in" },
			{ "zoomout", "zoom-out" },
			{ "bank", "bank" },
			{ "bankdos", "bank2" },
			{ "bellslashfill", "bell-slash-fill" },
			{ "bellslash", "bell-slash" },
			{ "cashcoin", "cash-coin" },
			{ "checklg", "check-lg" },
			{ "coin", "coin" },
			{ "currencybitcoin", "currency-bitcoin" },
			{ "currencydollar", "currency-dollar" },
			{ "currencyeuro", "currency-euro" },
			{ "currencyexchange", "currency-exchange" },
			{ "currencypound", "currency-pound" },
			{ "currencyyen", "currency-yen" },
			{ "dashlg", "dash-lg" },
			{ "exclamationlg", "exclamation-lg" },
			{ "fileearmarkpdffill", "file-earmark-pdf-fill" },
			{ "fileearmarkpdf", "file-earmark-pdf" },
			{ "filepdffill", "file-pdf-fill" },
			{ "filepdf", "file-pdf" },
			{ "genderambiguous", "gender-ambiguous" },
			{ "genderfemale", "gender-female" },
			{ "gendermale", "gender-male" },
			{ "gendertrans", "gender-trans" },
			{ "headsetvr", "headset-vr" },
			{ "infolg", "info-lg" },
			{ "mastodon", "mastodon" },
			{ "messenger", "messenger" },
			{ "piggybankfill", "piggy-bank-fill" },
			{ "piggybank", "piggy-bank" },
			{ "pinmapfill", "pin-map-fill" },
			{ "pinmap", "pin-map" },
			{ "pluslg", "plus-lg" },
			{ "questionlg", "question-lg" },
			{ "recycle", "recycle" },
			{ "reddit", "reddit" },
			{ "safefill", "safe-fill" },
			{ "safedosfill", "safe2-fill" },
			{ "safedos", "safe2" },
			{ "sdcardfill", "sd-card-fill" },
			{ "sdcard", "sd-card" },
			{ "skype", "skype" },
			{ "slashlg", "slash-lg" },
			{ "translate", "translate" },
			{ "xlg", "x-lg" },
			{ "safe", "safe" },
			{ "apple", "apple" },
			{ "microsoft", "microsoft" },
			{ "windows", "windows" },
			{ "behance", "behance" },
			{ "dribbble", "dribbble" },
			{ "line", "line" },
			{ "medium", "medium" },
			{ "paypal", "paypal" },
			{ "pinterest", "pinterest" },
			{ "signal", "signal" },
			{ "snapchat", "snapchat" },
			{ "spotify", "spotify" },
			{ "stackoverflow", "stack-overflow" },
			{ "strava", "strava" },
			{ "wordpress", "wordpress" },
			{ "vimeo", "vimeo" },
			{ "activity", "activity" },
			{ "easeldosfill", "easel2-fill" },
			{ "easeldos", "easel2" },
			{ "easeltresfill", "easel3-fill" },
			{ "easeltres", "easel3" },
			{ "fan", "fan" },
			{ "fingerprint", "fingerprint" },
			{ "graphdownarrow", "graph-down-arrow" },
			{ "graphuparrow", "graph-up-arrow" },
			{ "hypnotize", "hypnotize" },
			{ "magic", "magic" },
			{ "personrolodex", "person-rolodex" },
			{ "personvideo", "person-video" },
			{ "personvideodos", "person-video2" },
			{ "personvideotres", "person-video3" },
			{ "personworkspace", "person-workspace" },
			{ "radioactive", "radioactive" },
			{ "webcamfill", "webcam-fill" },
			{ "webcam", "webcam" },
			{ "yinyang", "yin-yang" },
			{ "bandaidfill", "bandaid-fill" },
			{ "bandaid", "bandaid" },
			{ "bluetooth", "bluetooth" },
			{ "bodytext", "body-text" },
			{ "boombox", "boombox" },
			{ "boxes", "boxes" },
			{ "dpadfill", "dpad-fill" },
			{ "dpad", "dpad" },
			{ "earfill", "ear-fill" },
			{ "ear", "ear" },
			{ "envelopecheckfill", "envelope-check-fill" },
			{ "envelopecheck", "envelope-check" },
			{ "envelopedashfill", "envelope-dash-fill" },
			{ "envelopedash", "envelope-dash" },
			{ "envelopeexclamationfill", "envelope-exclamation-fill" },
			{ "envelopeexclamation", "envelope-exclamation" },
			{ "envelopeplusfill", "envelope-plus-fill" },
			{ "envelopeplus", "envelope-plus" },
			{ "envelopeslashfill", "envelope-slash-fill" },
			{ "envelopeslash", "envelope-slash" },
			{ "envelopexfill", "envelope-x-fill" },
			{ "envelopex", "envelope-x" },
			{ "explicitfill", "explicit-fill" },
			{ "explicit", "explicit" },
			{ "git", "git" },
			{ "infinity", "infinity" },
			{ "listcolumnsreverse", "list-columns-reverse" },
			{ "listcolumns", "list-columns" },
			{ "meta", "meta" },
			{ "nintendoswitch", "nintendo-switch" },
			{ "pcdisplayhorizontal", "pc-display-horizontal" },
			{ "pcdisplay", "pc-display" },
			{ "pchorizontal", "pc-horizontal" },
			{ "pc", "pc" },
			{ "playstation", "playstation" },
			{ "plusslashminus", "plus-slash-minus" },
			{ "projectorfill", "projector-fill" },
			{ "projector", "projector" },
			{ "qrcodescan", "qr-code-scan" },
			{ "qrcode", "qr-code" },
			{ "quora", "quora" },
			{ "quote", "quote" },
			{ "robot", "robot" },
			{ "sendcheckfill", "send-check-fill" },
			{ "sendcheck", "send-check" },
			{ "senddashfill", "send-dash-fill" },
			{ "senddash", "send-dash" },
			{ "sendexclamationfill", "send-exclamation-fill" },
			{ "sendexclamation", "send-exclamation" },
			{ "sendfill", "send-fill" },
			{ "sendplusfill", "send-plus-fill" },
			{ "sendplus", "send-plus" },
			{ "sendslashfill", "send-slash-fill" },
			{ "sendslash", "send-slash" },
			{ "sendxfill", "send-x-fill" },
			{ "sendx", "send-x" },
			{ "send", "send" },
			{ "steam", "steam" },
			{ "terminaldash", "terminal-dash" },
			{ "terminalplus", "terminal-plus" },
			{ "terminalsplit", "terminal-split" },
			{ "ticketdetailedfill", "ticket-detailed-fill" },
			{ "ticketdetailed", "ticket-detailed" },
			{ "ticketfill", "ticket-fill" },
			{ "ticketperforatedfill", "ticket-perforated-fill" },
			{ "ticketperforated", "ticket-perforated" },
			{ "ticket", "ticket" },
			{ "tiktok", "tiktok" },
			{ "windowdash", "window-dash" },
			{ "windowdesktop", "window-desktop" },
			{ "windowfullscreen", "window-fullscreen" },
			{ "windowplus", "window-plus" },
			{ "windowsplit", "window-split" },
			{ "windowstack", "window-stack" },
			{ "windowx", "window-x" },
			{ "xbox", "xbox" },
			{ "ethernet", "ethernet" },
			{ "hdmifill", "hdmi-fill" },
			{ "hdmi", "hdmi" },
			{ "usbcfill", "usb-c-fill" },
			{ "usbc", "usb-c" },
			{ "usbfill", "usb-fill" },
			{ "usbplugfill", "usb-plug-fill" },
			{ "usbplug", "usb-plug" },
			{ "usbsymbol", "usb-symbol" },
			{ "usb", "usb" },
			{ "boomboxfill", "boombox-fill" },
			{ "displayport", "displayport" },
			{ "gpucard", "gpu-card" },
			{ "memory", "memory" },
			{ "modemfill", "modem-fill" },
			{ "modem", "modem" },
			{ "motherboardfill", "motherboard-fill" },
			{ "motherboard", "motherboard" },
			{ "opticalaudiofill", "optical-audio-fill" },
			{ "opticalaudio", "optical-audio" },
			{ "pcicard", "pci-card" },
			{ "routerfill", "router-fill" },
			{ "router", "router" },
			{ "thunderboltfill", "thunderbolt-fill" },
			{ "thunderbolt", "thunderbolt" },
			{ "usbdrivefill", "usb-drive-fill" },
			{ "usbdrive", "usb-drive" },
			{ "usbmicrofill", "usb-micro-fill" },
			{ "usbmicro", "usb-micro" },
			{ "usbminifill", "usb-mini-fill" },
			{ "usbmini", "usb-mini" },
			{ "cloudhazedos", "cloud-haze2" },
			{ "devicehddfill", "device-hdd-fill" },
			{ "devicehdd", "device-hdd" },
			{ "devicessdfill", "device-ssd-fill" },
			{ "devicessd", "device-ssd" },
			{ "displayportfill", "displayport-fill" },
			{ "mortarboardfill", "mortarboard-fill" },
			{ "mortarboard", "mortarboard" },
			{ "terminalx", "terminal-x" },
			{ "arrowthroughheartfill", "arrow-through-heart-fill" },
			{ "arrowthroughheart", "arrow-through-heart" },
			{ "badgesdfill", "badge-sd-fill" },
			{ "badgesd", "badge-sd" },
			{ "bagheartfill", "bag-heart-fill" },
			{ "bagheart", "bag-heart" },
			{ "balloonfill", "balloon-fill" },
			{ "balloonheartfill", "balloon-heart-fill" },
			{ "balloonheart", "balloon-heart" },
			{ "balloon", "balloon" },
			{ "boxdosfill", "box2-fill" },
			{ "boxdosheartfill", "box2-heart-fill" },
			{ "boxdosheart", "box2-heart" },
			{ "boxdos", "box2" },
			{ "bracesasterisk", "braces-asterisk" },
			{ "calendarheartfill", "calendar-heart-fill" },
			{ "calendarheart", "calendar-heart" },
			{ "calendardosheartfill", "calendar2-heart-fill" },
			{ "calendardosheart", "calendar2-heart" },
			{ "chatheartfill", "chat-heart-fill" },
			{ "chatheart", "chat-heart" },
			{ "chatleftheartfill", "chat-left-heart-fill" },
			{ "chatleftheart", "chat-left-heart" },
			{ "chatrightheartfill", "chat-right-heart-fill" },
			{ "chatrightheart", "chat-right-heart" },
			{ "chatsquareheartfill", "chat-square-heart-fill" },
			{ "chatsquareheart", "chat-square-heart" },
			{ "clipboardcheckfill", "clipboard-check-fill" },
			{ "clipboarddatafill", "clipboard-data-fill" },
			{ "clipboardfill", "clipboard-fill" },
			{ "clipboardheartfill", "clipboard-heart-fill" },
			{ "clipboardheart", "clipboard-heart" },
			{ "clipboardminusfill", "clipboard-minus-fill" },
			{ "clipboardplusfill", "clipboard-plus-fill" },
			{ "clipboardpulse", "clipboard-pulse" },
			{ "clipboardxfill", "clipboard-x-fill" },
			{ "clipboarddoscheckfill", "clipboard2-check-fill" },
			{ "clipboarddoscheck", "clipboard2-check" },
			{ "clipboarddosdatafill", "clipboard2-data-fill" },
			{ "clipboarddosdata", "clipboard2-data" },
			{ "clipboarddosfill", "clipboard2-fill" },
			{ "clipboarddosheartfill", "clipboard2-heart-fill" },
			{ "clipboarddosheart", "clipboard2-heart" },
			{ "clipboarddosminusfill", "clipboard2-minus-fill" },
			{ "clipboarddosminus", "clipboard2-minus" },
			{ "clipboarddosplusfill", "clipboard2-plus-fill" },
			{ "clipboarddosplus", "clipboard2-plus" },
			{ "clipboarddospulsefill", "clipboard2-pulse-fill" },
			{ "clipboarddospulse", "clipboard2-pulse" },
			{ "clipboarddosxfill", "clipboard2-x-fill" },
			{ "clipboarddosx", "clipboard2-x" },
			{ "clipboarddos", "clipboard2" },
			{ "emojikissfill", "emoji-kiss-fill" },
			{ "emojikiss", "emoji-kiss" },
			{ "envelopeheartfill", "envelope-heart-fill" },
			{ "envelopeheart", "envelope-heart" },
			{ "envelopeopenheartfill", "envelope-open-heart-fill" },
			{ "envelopeopenheart", "envelope-open-heart" },
			{ "envelopepaperfill", "envelope-paper-fill" },
			{ "envelopepaperheartfill", "envelope-paper-heart-fill" },
			{ "envelopepaperheart", "envelope-paper-heart" },
			{ "envelopepaper", "envelope-paper" },
			{ "filetypeaac", "filetype-aac" },
			{ "filetypeai", "filetype-ai" },
			{ "filetypebmp", "filetype-bmp" },
			{ "filetypecs", "filetype-cs" },
			{ "filetypecss", "filetype-css" },
			{ "filetypecsv", "filetype-csv" },
			{ "filetypedoc", "filetype-doc" },
			{ "filetypedocx", "filetype-docx" },
			{ "filetypeexe", "filetype-exe" },
			{ "filetypegif", "filetype-gif" },
			{ "filetypeheic", "filetype-heic" },
			{ "filetypehtml", "filetype-html" },
			{ "filetypejava", "filetype-java" },
			{ "filetypejpg", "filetype-jpg" },
			{ "filetypejs", "filetype-js" },
			{ "filetypejsx", "filetype-jsx" },
			{ "filetypekey", "filetype-key" },
			{ "filetypemcuatrop", "filetype-m4p" },
			{ "filetypemd", "filetype-md" },
			{ "filetypemdx", "filetype-mdx" },
			{ "filetypemov", "filetype-mov" },
			{ "filetypemptres", "filetype-mp3" },
			{ "filetypempcuatro", "filetype-mp4" },
			{ "filetypeotf", "filetype-otf" },
			{ "filetypepdf", "filetype-pdf" },
			{ "filetypephp", "filetype-php" },
			{ "filetypepng", "filetype-png" },
			{ "filetypeppt", "filetype-ppt" },
			{ "filetypepsd", "filetype-psd" },
			{ "filetypepy", "filetype-py" },
			{ "filetyperaw", "filetype-raw" },
			{ "filetyperb", "filetype-rb" },
			{ "filetypesass", "filetype-sass" },
			{ "filetypescss", "filetype-scss" },
			{ "filetypesh", "filetype-sh" },
			{ "filetypesvg", "filetype-svg" },
			{ "filetypetiff", "filetype-tiff" },
			{ "filetypetsx", "filetype-tsx" },
			{ "filetypettf", "filetype-ttf" },
			{ "filetypetxt", "filetype-txt" },
			{ "filetypewav", "filetype-wav" },
			{ "filetypewoff", "filetype-woff" },
			{ "filetypexls", "filetype-xls" },
			{ "filetypexml", "filetype-xml" },
			{ "filetypeyml", "filetype-yml" },
			{ "heartarrow", "heart-arrow" },
			{ "heartpulsefill", "heart-pulse-fill" },
			{ "heartpulse", "heart-pulse" },
			{ "heartbreakfill", "heartbreak-fill" },
			{ "heartbreak", "heartbreak" },
			{ "hearts", "hearts" },
			{ "hospitalfill", "hospital-fill" },
			{ "hospital", "hospital" },
			{ "househeartfill", "house-heart-fill" },
			{ "househeart", "house-heart" },
			{ "incognito", "incognito" },
			{ "magnetfill", "magnet-fill" },
			{ "magnet", "magnet" },
			{ "personheart", "person-heart" },
			{ "personhearts", "person-hearts" },
			{ "phoneflip", "phone-flip" },
			{ "plugin", "plugin" },
			{ "postagefill", "postage-fill" },
			{ "postageheartfill", "postage-heart-fill" },
			{ "postageheart", "postage-heart" },
			{ "postage", "postage" },
			{ "postcardfill", "postcard-fill" },
			{ "postcardheartfill", "postcard-heart-fill" },
			{ "postcardheart", "postcard-heart" },
			{ "postcard", "postcard" },
			{ "searchheartfill", "search-heart-fill" },
			{ "searchheart", "search-heart" },
			{ "slidersdosvertical", "sliders2-vertical" },
			{ "slidersdos", "sliders2" },
			{ "trashtresfill", "trash3-fill" },
			{ "trashtres", "trash3" },
			{ "valentine", "valentine" },
			{ "valentinedos", "valentine2" },
			{ "wrenchadjustablecirclefill", "wrench-adjustable-circle-fill" },
			{ "wrenchadjustablecircle", "wrench-adjustable-circle" },
			{ "wrenchadjustable", "wrench-adjustable" },
			{ "filetypejson", "filetype-json" },
			{ "filetypepptx", "filetype-pptx" },
			{ "filetypexlsx", "filetype-xlsx" },
			{ "unocirclefill", "1-circle-fill" },
			{ "unocircle", "1-circle" },
			{ "unosquarefill", "1-square-fill" },
			{ "unosquare", "1-square" },
			{ "doscirclefill", "2-circle-fill" },
			{ "doscircle", "2-circle" },
			{ "dossquarefill", "2-square-fill" },
			{ "dossquare", "2-square" },
			{ "trescirclefill", "3-circle-fill" },
			{ "trescircle", "3-circle" },
			{ "tressquarefill", "3-square-fill" },
			{ "tressquare", "3-square" },
			{ "cuatrocirclefill", "4-circle-fill" },
			{ "cuatrocircle", "4-circle" },
			{ "cuatrosquarefill", "4-square-fill" },
			{ "cuatrosquare", "4-square" },
			{ "cincocirclefill", "5-circle-fill" },
			{ "cincocircle", "5-circle" },
			{ "cincosquarefill", "5-square-fill" },
			{ "cincosquare", "5-square" },
			{ "seiscirclefill", "6-circle-fill" },
			{ "seiscircle", "6-circle" },
			{ "seissquarefill", "6-square-fill" },
			{ "seissquare", "6-square" },
			{ "sietecirclefill", "7-circle-fill" },
			{ "sietecircle", "7-circle" },
			{ "sietesquarefill", "7-square-fill" },
			{ "sietesquare", "7-square" },
			{ "ochocirclefill", "8-circle-fill" },
			{ "ochocircle", "8-circle" },
			{ "ochosquarefill", "8-square-fill" },
			{ "ochosquare", "8-square" },
			{ "nuevecirclefill", "9-circle-fill" },
			{ "nuevecircle", "9-circle" },
			{ "nuevesquarefill", "9-square-fill" },
			{ "nuevesquare", "9-square" },
			{ "airplaneenginesfill", "airplane-engines-fill" },
			{ "airplaneengines", "airplane-engines" },
			{ "airplanefill", "airplane-fill" },
			{ "airplane", "airplane" },
			{ "alexa", "alexa" },
			{ "alipay", "alipay" },
			{ "android", "android" },
			{ "androiddos", "android2" },
			{ "boxfill", "box-fill" },
			{ "boxseamfill", "box-seam-fill" },
			{ "browserchrome", "browser-chrome" },
			{ "browseredge", "browser-edge" },
			{ "browserfirefox", "browser-firefox" },
			{ "browsersafari", "browser-safari" },
			{ "ccirclefill", "c-circle-fill" },
			{ "ccircle", "c-circle" },
			{ "csquarefill", "c-square-fill" },
			{ "csquare", "c-square" },
			{ "capsulepill", "capsule-pill" },
			{ "capsule", "capsule" },
			{ "carfrontfill", "car-front-fill" },
			{ "carfront", "car-front" },
			{ "cassettefill", "cassette-fill" },
			{ "cassette", "cassette" },
			{ "cccirclefill", "cc-circle-fill" },
			{ "cccircle", "cc-circle" },
			{ "ccsquarefill", "cc-square-fill" },
			{ "ccsquare", "cc-square" },
			{ "cuphotfill", "cup-hot-fill" },
			{ "cuphot", "cup-hot" },
			{ "currencyrupee", "currency-rupee" },
			{ "dropbox", "dropbox" },
			{ "escape", "escape" },
			{ "fastforwardbtnfill", "fast-forward-btn-fill" },
			{ "fastforwardbtn", "fast-forward-btn" },
			{ "fastforwardcirclefill", "fast-forward-circle-fill" },
			{ "fastforwardcircle", "fast-forward-circle" },
			{ "fastforwardfill", "fast-forward-fill" },
			{ "fastforward", "fast-forward" },
			{ "filetypesql", "filetype-sql" },
			{ "fire", "fire" },
			{ "googleplay", "google-play" },
			{ "hcirclefill", "h-circle-fill" },
			{ "hcircle", "h-circle" },
			{ "hsquarefill", "h-square-fill" },
			{ "hsquare", "h-square" },
			{ "indent", "indent" },
			{ "lungsfill", "lungs-fill" },
			{ "lungs", "lungs" },
			{ "microsoftteams", "microsoft-teams" },
			{ "pcirclefill", "p-circle-fill" },
			{ "pcircle", "p-circle" },
			{ "psquarefill", "p-square-fill" },
			{ "psquare", "p-square" },
			{ "passfill", "pass-fill" },
			{ "pass", "pass" },
			{ "prescription", "prescription" },
			{ "prescriptiondos", "prescription2" },
			{ "rcirclefill", "r-circle-fill" },
			{ "rcircle", "r-circle" },
			{ "rsquarefill", "r-square-fill" },
			{ "rsquare", "r-square" },
			{ "repeatuno", "repeat-1" },
			{ "repeat", "repeat" },
			{ "rewindbtnfill", "rewind-btn-fill" },
			{ "rewindbtn", "rewind-btn" },
			{ "rewindcirclefill", "rewind-circle-fill" },
			{ "rewindcircle", "rewind-circle" },
			{ "rewindfill", "rewind-fill" },
			{ "rewind", "rewind" },
			{ "trainfreightfrontfill", "train-freight-front-fill" },
			{ "trainfreightfront", "train-freight-front" },
			{ "trainfrontfill", "train-front-fill" },
			{ "trainfront", "train-front" },
			{ "trainlightrailfrontfill", "train-lightrail-front-fill" },
			{ "trainlightrailfront", "train-lightrail-front" },
			{ "truckfrontfill", "truck-front-fill" },
			{ "truckfront", "truck-front" },
			{ "ubuntu", "ubuntu" },
			{ "unindent", "unindent" },
			{ "unity", "unity" },
			{ "universalaccesscircle", "universal-access-circle" },
			{ "universalaccess", "universal-access" },
			{ "virus", "virus" },
			{ "virusdos", "virus2" },
			{ "wechat", "wechat" },
			{ "yelp", "yelp" },
			{ "signstopfill", "sign-stop-fill" },
			{ "signstoplightsfill", "sign-stop-lights-fill" },
			{ "signstoplights", "sign-stop-lights" },
			{ "signstop", "sign-stop" },
			{ "signturnleftfill", "sign-turn-left-fill" },
			{ "signturnleft", "sign-turn-left" },
			{ "signturnrightfill", "sign-turn-right-fill" },
			{ "signturnright", "sign-turn-right" },
			{ "signturnslightleftfill", "sign-turn-slight-left-fill" },
			{ "signturnslightleft", "sign-turn-slight-left" },
			{ "signturnslightrightfill", "sign-turn-slight-right-fill" },
			{ "signturnslightright", "sign-turn-slight-right" },
			{ "signyieldfill", "sign-yield-fill" },
			{ "signyield", "sign-yield" },
			{ "evstationfill", "ev-station-fill" },
			{ "evstation", "ev-station" },
			{ "fuelpumpdieselfill", "fuel-pump-diesel-fill" },
			{ "fuelpumpdiesel", "fuel-pump-diesel" },
			{ "fuelpumpfill", "fuel-pump-fill" },
			{ "fuelpump", "fuel-pump" },
			{ "zerocirclefill", "0-circle-fill" },
			{ "zerocircle", "0-circle" },
			{ "zerosquarefill", "0-square-fill" },
			{ "zerosquare", "0-square" },
			{ "rocketfill", "rocket-fill" },
			{ "rockettakeofffill", "rocket-takeoff-fill" },
			{ "rockettakeoff", "rocket-takeoff" },
			{ "rocket", "rocket" },
			{ "stripe", "stripe" },
			{ "subscript", "subscript" },
			{ "superscript", "superscript" },
			{ "trello", "trello" },
			{ "envelopeatfill", "envelope-at-fill" },
			{ "envelopeat", "envelope-at" },
			{ "regex", "regex" },
			{ "textwrap", "text-wrap" },
			{ "signdeadendfill", "sign-dead-end-fill" },
			{ "signdeadend", "sign-dead-end" },
			{ "signdonotenterfill", "sign-do-not-enter-fill" },
			{ "signdonotenter", "sign-do-not-enter" },
			{ "signintersectionfill", "sign-intersection-fill" },
			{ "signintersectionsidefill", "sign-intersection-side-fill" },
			{ "signintersectionside", "sign-intersection-side" },
			{ "signintersectiontfill", "sign-intersection-t-fill" },
			{ "signintersectiont", "sign-intersection-t" },
			{ "signintersectionyfill", "sign-intersection-y-fill" },
			{ "signintersectiony", "sign-intersection-y" },
			{ "signintersection", "sign-intersection" },
			{ "signmergeleftfill", "sign-merge-left-fill" },
			{ "signmergeleft", "sign-merge-left" },
			{ "signmergerightfill", "sign-merge-right-fill" },
			{ "signmergeright", "sign-merge-right" },
			{ "signnoleftturnfill", "sign-no-left-turn-fill" },
			{ "signnoleftturn", "sign-no-left-turn" },
			{ "signnoparkingfill", "sign-no-parking-fill" },
			{ "signnoparking", "sign-no-parking" },
			{ "signnorightturnfill", "sign-no-right-turn-fill" },
			{ "signnorightturn", "sign-no-right-turn" },
			{ "signrailroadfill", "sign-railroad-fill" },
			{ "signrailroad", "sign-railroad" },
			{ "buildingadd", "building-add" },
			{ "buildingcheck", "building-check" },
			{ "buildingdash", "building-dash" },
			{ "buildingdown", "building-down" },
			{ "buildingexclamation", "building-exclamation" },
			{ "buildingfilladd", "building-fill-add" },
			{ "buildingfillcheck", "building-fill-check" },
			{ "buildingfilldash", "building-fill-dash" },
			{ "buildingfilldown", "building-fill-down" },
			{ "buildingfillexclamation", "building-fill-exclamation" },
			{ "buildingfillgear", "building-fill-gear" },
			{ "buildingfilllock", "building-fill-lock" },
			{ "buildingfillslash", "building-fill-slash" },
			{ "buildingfillup", "building-fill-up" },
			{ "buildingfillx", "building-fill-x" },
			{ "buildingfill", "building-fill" },
			{ "buildinggear", "building-gear" },
			{ "buildinglock", "building-lock" },
			{ "buildingslash", "building-slash" },
			{ "buildingup", "building-up" },
			{ "buildingx", "building-x" },
			{ "buildingsfill", "buildings-fill" },
			{ "buildings", "buildings" },
			{ "busfrontfill", "bus-front-fill" },
			{ "busfront", "bus-front" },
			{ "evfrontfill", "ev-front-fill" },
			{ "evfront", "ev-front" },
			{ "globeamericas", "globe-americas" },
			{ "globeasiaaustralia", "globe-asia-australia" },
			{ "globecentralsouthasia", "globe-central-south-asia" },
			{ "globeeuropeafrica", "globe-europe-africa" },
			{ "houseaddfill", "house-add-fill" },
			{ "houseadd", "house-add" },
			{ "housecheckfill", "house-check-fill" },
			{ "housecheck", "house-check" },
			{ "housedashfill", "house-dash-fill" },
			{ "housedash", "house-dash" },
			{ "housedownfill", "house-down-fill" },
			{ "housedown", "house-down" },
			{ "houseexclamationfill", "house-exclamation-fill" },
			{ "houseexclamation", "house-exclamation" },
			{ "housegearfill", "house-gear-fill" },
			{ "housegear", "house-gear" },
			{ "houselockfill", "house-lock-fill" },
			{ "houselock", "house-lock" },
			{ "houseslashfill", "house-slash-fill" },
			{ "houseslash", "house-slash" },
			{ "houseupfill", "house-up-fill" },
			{ "houseup", "house-up" },
			{ "housexfill", "house-x-fill" },
			{ "housex", "house-x" },
			{ "personadd", "person-add" },
			{ "persondown", "person-down" },
			{ "personexclamation", "person-exclamation" },
			{ "personfilladd", "person-fill-add" },
			{ "personfillcheck", "person-fill-check" },
			{ "personfilldash", "person-fill-dash" },
			{ "personfilldown", "person-fill-down" },
			{ "personfillexclamation", "person-fill-exclamation" },
			{ "personfillgear", "person-fill-gear" },
			{ "personfilllock", "person-fill-lock" },
			{ "personfillslash", "person-fill-slash" },
			{ "personfillup", "person-fill-up" },
			{ "personfillx", "person-fill-x" },
			{ "persongear", "person-gear" },
			{ "personlock", "person-lock" },
			{ "personslash", "person-slash" },
			{ "personup", "person-up" },
			{ "scooter", "scooter" },
			{ "taxifrontfill", "taxi-front-fill" },
			{ "taxifront", "taxi-front" },
			{ "amd", "amd" },
			{ "databaseadd", "database-add" },
			{ "databasecheck", "database-check" },
			{ "databasedash", "database-dash" },
			{ "databasedown", "database-down" },
			{ "databaseexclamation", "database-exclamation" },
			{ "databasefilladd", "database-fill-add" },
			{ "databasefillcheck", "database-fill-check" },
			{ "databasefilldash", "database-fill-dash" },
			{ "databasefilldown", "database-fill-down" },
			{ "databasefillexclamation", "database-fill-exclamation" },
			{ "databasefillgear", "database-fill-gear" },
			{ "databasefilllock", "database-fill-lock" },
			{ "databasefillslash", "database-fill-slash" },
			{ "databasefillup", "database-fill-up" },
			{ "databasefillx", "database-fill-x" },
			{ "databasefill", "database-fill" },
			{ "databasegear", "database-gear" },
			{ "databaselock", "database-lock" },
			{ "databaseslash", "database-slash" },
			{ "databaseup", "database-up" },
			{ "databasex", "database-x" },
			{ "database", "database" },
			{ "housesfill", "houses-fill" },
			{ "houses", "houses" },
			{ "nvidia", "nvidia" },
			{ "personvcardfill", "person-vcard-fill" },
			{ "personvcard", "person-vcard" },
			{ "sinaweibo", "sina-weibo" },
			{ "tencentqq", "tencent-qq" },
			{ "wikipedia", "wikipedia" }
		};

		#endregion Icon
	}


public partial class EmpleadoScriptsUser
{
}

    public class EmpleadoControls
    {
       #region Constructores

       /// <summary>
       /// En caso de requerir instancias desde el despachador de blazor se inicializan aquí.
       /// </summary>
       public EmpleadoControls() { }

       #endregion Constructores

        #region Root
        
        //Este código fue generado por el fichero WoFormView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorContainers\WoForm\WoFormView.cs
        //WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Instancia de la vista del formulario Root.
        /// </summary>
        public WoFormView Root { get; set; } = new WoFormView();

        #endregion Root


        #region tabGroupBase
        
        // Este código fue generado por el fichero WoFormTabsView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorContainers\WoFormTabs\WoFormTabsView.cs.
        // WoWSB por el generador a día 5-10-2023
        /// <summary>
        /// Instancia de la vista del input de texto tabGroupBase.
        /// </summary>
        public WoFormView tabGroupBase { get; set; } = new WoFormView();

        #endregion tabGroupBase


        #region formFormModel
        
        // Este código fue generado por el fichero WoFormTabView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorContainers\WoFormTab\WoFormTabView.cs
        // WoWSB por el generador a día 5-10-2023
        /// <summary>
        /// Instancia de la vista del input de texto formFormModel.
        /// </summary>
        public WoFormTabView formFormModel { get; set; } = new WoFormTabView();

        #endregion formFormModel

        #region Id

        // Este código fue generado por el fichero WoTextEditView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditView.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoEditView Id { get; set; } = new WoEditView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoFormItemView IdContainer { get; set; } = new WoFormItemView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoInputAlertView IdAlert { get; set; } = new WoInputAlertView();
        #endregion Id

        #region Nombre

        // Este código fue generado por el fichero WoTextEditView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditView.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoEditView Nombre { get; set; } = new WoEditView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoFormItemView NombreContainer { get; set; } = new WoFormItemView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoInputAlertView NombreAlert { get; set; } = new WoInputAlertView();
        #endregion Nombre

        #region FechaDeNacimiento

        // Este código fue generado por el fichero WoDateEditView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoDateEdit\WoDateEditView.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoEditView FechaDeNacimiento { get; set; } = new WoEditView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoFormItemView FechaDeNacimientoContainer { get; set; } = new WoFormItemView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoInputAlertView FechaDeNacimientoAlert { get; set; } = new WoInputAlertView();
        #endregion FechaDeNacimiento

        #region EstadoCivil

        // Este código fue generado por el fichero WoComboEnumEditView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoComboEnumEdit\WoComboEnumEditView.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoEditView EstadoCivil { get; set; } = new WoEditView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoFormItemView EstadoCivilContainer { get; set; } = new WoFormItemView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoInputAlertView EstadoCivilAlert { get; set; } = new WoInputAlertView();
        #endregion EstadoCivil

        #region Salario

        // Este código fue generado por el fichero WoMaskedEditView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoMaskedEdit\WoMaskedEditView.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoEditView Salario { get; set; } = new WoEditView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoFormItemView SalarioContainer { get; set; } = new WoFormItemView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoInputAlertView SalarioAlert { get; set; } = new WoInputAlertView();
        #endregion Salario

        #region Correo

        // Este código fue generado por el fichero WoMaskedEditView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoMaskedEdit\WoMaskedEditView.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoEditView Correo { get; set; } = new WoEditView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoFormItemView CorreoContainer { get; set; } = new WoFormItemView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoInputAlertView CorreoAlert { get; set; } = new WoInputAlertView();
        #endregion Correo

        #region Telefono

        // Este código fue generado por el fichero WoMaskedEditView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoMaskedEdit\WoMaskedEditView.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoEditView Telefono { get; set; } = new WoEditView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoFormItemView TelefonoContainer { get; set; } = new WoFormItemView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoInputAlertView TelefonoAlert { get; set; } = new WoInputAlertView();
        #endregion Telefono

        #region TipoDeEmpleadoId

        // Este código fue generado por el fichero WoLookUpEditView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoLookUpEdit\WoLookUpEditView.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoEditView TipoDeEmpleadoId { get; set; } = new WoEditView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoFormItemView TipoDeEmpleadoIdContainer { get; set; } = new WoFormItemView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoInputAlertView TipoDeEmpleadoIdAlert { get; set; } = new WoInputAlertView();
        #endregion TipoDeEmpleadoId


        #region formControlform
        
        // Este código fue generado por el fichero WoFormTabView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorContainers\WoFormTab\WoFormTabView.cs
        // WoWSB por el generador a día 5-10-2023
        /// <summary>
        /// Instancia de la vista del input de texto formControlform.
        /// </summary>
        public WoFormTabView formControlform { get; set; } = new WoFormTabView();

        #endregion formControlform

        #region WoState

        // Este código fue generado por el fichero WoComboEnumEditView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoComboEnumEdit\WoComboEnumEditView.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoEditView WoState { get; set; } = new WoEditView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoFormItemView WoStateContainer { get; set; } = new WoFormItemView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoInputAlertView WoStateAlert { get; set; } = new WoInputAlertView();
        #endregion WoState

        #region CreatedDate

        // Este código fue generado por el fichero WoDateEditView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoDateEdit\WoDateEditView.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoEditView CreatedDate { get; set; } = new WoEditView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoFormItemView CreatedDateContainer { get; set; } = new WoFormItemView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoInputAlertView CreatedDateAlert { get; set; } = new WoInputAlertView();
        #endregion CreatedDate

        #region CreatedBy

        // Este código fue generado por el fichero WoTextEditView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditView.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoEditView CreatedBy { get; set; } = new WoEditView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoFormItemView CreatedByContainer { get; set; } = new WoFormItemView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoInputAlertView CreatedByAlert { get; set; } = new WoInputAlertView();
        #endregion CreatedBy

        #region ModifiedDate

        // Este código fue generado por el fichero WoDateEditView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoDateEdit\WoDateEditView.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoEditView ModifiedDate { get; set; } = new WoEditView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoFormItemView ModifiedDateContainer { get; set; } = new WoFormItemView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoInputAlertView ModifiedDateAlert { get; set; } = new WoInputAlertView();
        #endregion ModifiedDate

        #region ModifiedBy

        // Este código fue generado por el fichero WoTextEditView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditView.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoEditView ModifiedBy { get; set; } = new WoEditView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoFormItemView ModifiedByContainer { get; set; } = new WoFormItemView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoInputAlertView ModifiedByAlert { get; set; } = new WoInputAlertView();
        #endregion ModifiedBy

        #region SuspendDate

        // Este código fue generado por el fichero WoDateEditView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoDateEdit\WoDateEditView.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoEditView SuspendDate { get; set; } = new WoEditView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoFormItemView SuspendDateContainer { get; set; } = new WoFormItemView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoInputAlertView SuspendDateAlert { get; set; } = new WoInputAlertView();
        #endregion SuspendDate

        #region SuspendBy

        // Este código fue generado por el fichero WoTextEditView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditView.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoEditView SuspendBy { get; set; } = new WoEditView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoFormItemView SuspendByContainer { get; set; } = new WoFormItemView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoInputAlertView SuspendByAlert { get; set; } = new WoInputAlertView();
        #endregion SuspendBy

        #region SuspendInfo

        // Este código fue generado por el fichero WoTextEditView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditView.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoEditView SuspendInfo { get; set; } = new WoEditView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoFormItemView SuspendInfoContainer { get; set; } = new WoFormItemView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoInputAlertView SuspendInfoAlert { get; set; } = new WoInputAlertView();
        #endregion SuspendInfo

        #region DeletedDate

        // Este código fue generado por el fichero WoDateEditView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoDateEdit\WoDateEditView.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoEditView DeletedDate { get; set; } = new WoEditView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoFormItemView DeletedDateContainer { get; set; } = new WoFormItemView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoInputAlertView DeletedDateAlert { get; set; } = new WoInputAlertView();
        #endregion DeletedDate

        #region DeletedBy

        // Este código fue generado por el fichero WoTextEditView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditView.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoEditView DeletedBy { get; set; } = new WoEditView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoFormItemView DeletedByContainer { get; set; } = new WoFormItemView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoInputAlertView DeletedByAlert { get; set; } = new WoInputAlertView();
        #endregion DeletedBy

        #region DeleteInfo

        // Este código fue generado por el fichero WoTextEditView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditView.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoEditView DeleteInfo { get; set; } = new WoEditView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoFormItemView DeleteInfoContainer { get; set; } = new WoFormItemView();

        /// <summary>
        /// Instancia de la vista del input de texto Usuario.
        /// </summary>
        public WoInputAlertView DeleteInfoAlert { get; set; } = new WoInputAlertView();
        #endregion DeleteInfo


        #region Alertas
        
        // Este código fue generado por el fichero WoAlertListView.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorAlerts\WoAlertList\WoAlertListView.cs
        // WoWSB por el generador a día 5-10-2023
        /// <summary>
        /// Instancia de la vista de alertas.
        /// </summary>
        public WoFormAlertView Alertas { get; set; } = new WoFormAlertView();

        #endregion Alertas
        #region Toolbar

        // Este código fue generado por el fichero WoRecordToolBarView.cs

        /// <summary>
        /// Instancia de la vista del toolbar.
        /// </summary>
        public WoFormToolbarView Controles { get; set; } = new WoFormToolbarView();

        /// <summary>
        /// Instancia de la vista del boton de compartir del toolbar.
        /// </summary>
        public WoShareButtonView Compartir { get; set; } = new WoShareButtonView();
        #endregion Toolbar

    }


public class WoFormGroupView : AWoCommonFormViewBase
{
    #region Icono

    /// <summary>
    /// Representa el icono.
    /// </summary>
    private eBoostrapIcons _icon = eBoostrapIcons.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el icono.
    /// </summary>
    public event EventHandler<eBoostrapIcons>? ChangeIconEvt;

    /// <summary>
    /// Método para cambiar el ícono.
    /// </summary>
    public void ChangeIcon(eBoostrapIcons icon)
    {
        _icon = icon;
        InvokeChangeIcon();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeIcon()
    {
        ChangeIconEvt?.Invoke(this, _icon);
    }

    #endregion Icono

    #region Actualización general del render del componente

    /// <summary>
    /// Actualiza el renderizado del componente para que 
    /// se le pasen los datos de la view al componente.
    /// Nota: Hay que realizar esto luego de suscribir los eventos
    /// puesto que los usara para actualizar el renderizado.
    /// </summary>
    public override void ActualizarComponente()
    {
        InvokeChangeIcon();
    }

    #endregion Actualización general del render del componente
}

public class WoFormTabView : AWoCommonFormViewBase
{
    #region Icon

    /// <summary>
    /// Representa el icono.
    /// </summary>
    private eBoostrapIcons _icon = eBoostrapIcons.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el icono.
    /// </summary>
    public event EventHandler<eBoostrapIcons>? ChangeIconEvt;

    /// <summary>
    /// Método para cambiar el ícono.
    /// </summary>
    public void ChangeIcon(eBoostrapIcons icon)
    {
        _icon = icon;
        InvokeChangeIcon();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeIcon()
    {
        ChangeIconEvt?.Invoke(this, _icon);
    }

    #endregion Icon

    #region Actualización general del render del componente

    /// <summary>
    /// Actualiza el renderizado del componente para que 
    /// se le pasen los datos de la view al componente.
    /// Nota: Hay que realizar esto luego de suscribir los eventos
    /// puesto que los usara para actualizar el renderizado.
    /// </summary>
    public override void ActualizarComponente()
    {
        InvokeChangeIcon();
    }

    #endregion Actualización general del render del componente
}

public class WoFormView : AWoCommonFormViewBase
{
}

public class AWoCommonFormViewBase
{
    #region Color del fondo

    /// <summary>
    /// Representa el color del fondo.
    /// </summary>
    private eGroupColor _backColor = eGroupColor.Default;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el color del fondo.
    /// </summary>
    public event EventHandler<eGroupColor>? ChangeBackColorEvt;

    /// <summary>
    /// Cambiar color del fondo desde el script o otro lado.
    /// </summary>
    /// <param name="newColor"></param>
    public void ColorDeFondo(eGroupColor color)
    {
        _backColor = color;
        InvokeChangeBackGround();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeBackGround()
    {
        ChangeBackColorEvt?.Invoke(this, _backColor);
    }

    #endregion Color del fondo


    #region Fuente

    #region Negrita

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextWeight _fontWeight = eTextWeight.Normal;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextWeight>? ChangeFontWeightEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void GrosorDeLetra(eTextWeight negrita)
    {
        _fontWeight = negrita;
        InvokeChangeFontWeight();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeFontWeight()
    {
        ChangeFontWeightEvt?.Invoke(this, _fontWeight);
    }

    #endregion Negrita

    #region Italica

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextItalic _fontItalic = eTextItalic.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextItalic>? ChangeFontItalicEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void Italica(eTextItalic italica)
    {
        _fontItalic = italica;
        InvokeChangeFontItalic();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeFontItalic()
    {
        ChangeFontItalicEvt?.Invoke(this, _fontItalic);
    }

    #endregion Italica

    #region Tachado/Subrayado

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextDecoration _fontDecoration = eTextDecoration.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextDecoration>? ChangeFontDecorationEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void DecoracionDeLetra(eTextDecoration decoracion)
    {
        _fontDecoration = decoracion;
        InvokeChangeFontDecoration();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeFontDecoration()
    {
        ChangeFontDecorationEvt?.Invoke(this, _fontDecoration);
    }

    #endregion Tachado/Subrayado

    #region Color de fuente

    /// <summary>
    /// Representa el calor del color de la letra.
    /// </summary>
    private eTextColor _fontColor = eTextColor.FontDefault;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el color de letra.
    /// </summary>
    public event EventHandler<eTextColor>? ChangeFontColorEvt;

    /// <summary>
    /// Cambiar color de la letra desde el script o otro lado.
    /// </summary>
    /// <param name="newColor"></param>
    public void ColorDeLetra(eTextColor color)
    {
        _fontColor = color;
        InvokeChangeFontColor();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeFontColor()
    {
        ChangeFontColorEvt?.Invoke(this, _fontColor);
    }

    #endregion Color de fuente

    #endregion Fuente


    #region Actualización general del render del componente

    /// <summary>
    /// Actualiza el renderizado del componente para que 
    /// se le pasen los datos de la view al componente.
    /// Nota: Hay que realizar esto luego de suscribir los eventos
    /// puesto que los usara para actualizar el renderizado.
    /// </summary>
    public virtual void ActualizarComponente()
    {
        InvokeChangeFontColor();
        InvokeChangeFontWeight();
        InvokeChangeFontItalic();
        InvokeChangeFontDecoration();
        InvokeChangeBackGround();
    }

    #endregion Actualización general del render del componente
}


public class WoEditView : AWoCommonEditViewBase
{
}

public class AWoCommonEditViewBase
{
    #region Color del fondo

    /// <summary>
    /// Representa el color del fondo.
    /// </summary>
    private eContainerItemColor _backColor = eContainerItemColor.Default;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el color del fondo.
    /// </summary>
    public event EventHandler<eContainerItemColor>? ChangeBackColorEvt;

    /// <summary>
    /// Cambiar color del fondo desde el script o otro lado.
    /// </summary>
    /// <param name="newColor"></param>
    public void ColorDeFondo(eContainerItemColor color)
    {
        _backColor = color;
        InvokeChangeBackGround();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeBackGround()
    {
        ChangeBackColorEvt?.Invoke(this, _backColor);
    }

    #endregion Color del fondo


    #region Color de Letra

    /// <summary>
    /// Representa el calor del color de la letra.
    /// </summary>
    private eTextColor _controlFontColor = eTextColor.FontDefault;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el color de letra.
    /// </summary>
    public event EventHandler<eTextColor>? ChangeControlFontColorEvt;

    /// <summary>
    /// Cambiar color de la letra desde el script o otro lado.
    /// </summary>
    /// <param name="newColor"></param>
    public void ColorDeLetraDeControl(eTextColor color)
    {
        _controlFontColor = color;
        InvokeChangeControlFontColor();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeControlFontColor()
    {
        ChangeControlFontColorEvt?.Invoke(this, _controlFontColor);
    }

    #endregion Color de Letra

    #region Negrita

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextWeight _controlFontWeight = eTextWeight.Normal;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextWeight>? ChangeControlFontWeightEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void GrosorDeLetraDeControl(eTextWeight negrita)
    {
        _controlFontWeight = negrita;
        InvokeChangeControlFontWeight();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeControlFontWeight()
    {
        ChangeControlFontWeightEvt?.Invoke(this, _controlFontWeight);
    }

    #endregion Negrita

    #region Italica

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextItalic _controlFontItalic = eTextItalic.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextItalic>? ChangeControlFontItalicEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void ControlEnItalica(eTextItalic italica)
    {
        _controlFontItalic = italica;
        InvokeChangeControlFontItalic();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeControlFontItalic()
    {
        ChangeControlFontItalicEvt?.Invoke(this, _controlFontItalic);
    }

    #endregion Italica

    #region Tachado/Subrayado

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextDecoration _controlFontDecoration = eTextDecoration.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextDecoration>? ChangeControlFontDecorationEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void DecoracionDeLetraDeControl(eTextDecoration decoracion)
    {
        _controlFontDecoration = decoracion;
        InvokeChangeControlFontDecoration();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeControlFontDecoration()
    {
        ChangeControlFontDecorationEvt?.Invoke(this, _controlFontDecoration);
    }

    #endregion Tachado/Subrayado

    #region Tamaño de letra

    /// <summary>
    /// Representa el valor del tamaño del control.
    /// </summary>
    private eItemSize _size = eItemSize.Small;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar el tamaño del componente.
    /// </summary>
    public event EventHandler<eItemSize>? ChangeSizeEvt;

    /// <summary>
    /// Métodos con los que interactue el usuario desde el editor para modificar el
    /// tamaño del control.
    /// </summary>
    public void TamañoDeLetra(eItemSize tamaño)
    {
        _size = tamaño;
        InvokeChangeSize();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos del cambio de tamaño y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeSize()
    {
        ChangeSizeEvt?.Invoke(this, _size);
    }

    #endregion Tamaño de letra


    #region Des/Habilitar control

    /// <summary>
    /// Indica si el control esta habilitado.
    /// </summary>
    private bool _status = true;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar si el componente esta habilitado o des habilitado.
    /// </summary>
    public event EventHandler<bool>? ChangeEnabledEvt;

    /// <summary>
    /// Método con los que interactue el usuario desde el editor para
    /// habilitar o deshabilitar el control.
    /// </summary>
    public void EstadoHabilitado(bool estado)
    {
        _status = estado;
        InvokeChangeEnabled();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos de la 
    /// habilitación del control y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeEnabled()
    {
        ChangeEnabledEvt?.Invoke(this, _status);
    }

    #endregion Des/Habilitar control


    #region Actualización general del render del componente

    /// <summary>
    /// Actualiza el renderizado del componente para que 
    /// se le pasen los datos de la view al componente.
    /// Nota: Hay que realizar esto luego de suscribir los eventos
    /// puesto que los usara para actualizar el renderizado.
    /// </summary>
    public void ActualizarComponente()
    {
        InvokeChangeControlFontWeight();
        InvokeChangeControlFontItalic();
        InvokeChangeControlFontDecoration();
        InvokeChangeBackGround();
        InvokeChangeSize();
        InvokeChangeEnabled();
    }

    #endregion Actualización general del render del componente
}


public class WoFormItemView
{
    #region Color de Letra

    /// <summary>
    /// Representa el calor del color de la letra.
    /// </summary>
    private eTextColor _CaptionFontColor = eTextColor.FontDefault;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el color de letra.
    /// </summary>
    public event EventHandler<eTextColor>? ChangeCaptionFontColorEvt;

    /// <summary>
    /// Cambiar color de la letra desde el script o otro lado.
    /// </summary>
    /// <param name="newColor"></param>
    public void ColorDeLetraDeTitulo(eTextColor color)
    {
        _CaptionFontColor = color;
        InvokeChangeCaptionFontColor();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeCaptionFontColor()
    {
        ChangeCaptionFontColorEvt?.Invoke(this, _CaptionFontColor);
    }

    #endregion Color de Letra

    #region Negrita

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextWeight _captionFontWeight = eTextWeight.Normal;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextWeight>? ChangeCaptionFontWeightEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void GrosorDeLetraDeTitulo(eTextWeight negrita)
    {
        _captionFontWeight = negrita;
        InvokeChangeCaptionFontWeight();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeCaptionFontWeight()
    {
        ChangeCaptionFontWeightEvt?.Invoke(this, _captionFontWeight);
    }

    #endregion Negrita

    #region Italica

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextItalic _captionFontItalic = eTextItalic.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextItalic>? ChangeCaptionFontItalicEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void TtuloEnItalica(eTextItalic italica)
    {
        _captionFontItalic = italica;
        InvokeChangeCaptionFontItalic();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeCaptionFontItalic()
    {
        ChangeCaptionFontItalicEvt?.Invoke(this, _captionFontItalic);
    }

    #endregion Italica

    #region Tachado/Subrayado

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextDecoration _captionFontDecoration = eTextDecoration.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextDecoration>? ChangeCaptionFontDecorationEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void DecoracionDeLetraDeTitulo(eTextDecoration decoracion)
    {
        _captionFontDecoration = decoracion;
        InvokeChangeCaptionFontDecoration();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeCaptionFontDecoration()
    {
        ChangeCaptionFontDecorationEvt?.Invoke(this, _captionFontDecoration);
    }

    #endregion Tachado/Subrayado

    #region Tamaño de letra

    /// <summary>
    /// Representa el valor del tamaño del control.
    /// </summary>
    private eItemSize _size = eItemSize.Small;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar el tamaño del componente.
    /// </summary>
    public event EventHandler<eItemSize>? ChangeSizeEvt;

    /// <summary>
    /// Métodos con los que interactue el usuario desde el editor para modificar el
    /// tamaño del control.
    /// </summary>
    public void TamañoDeLetra(eItemSize tamaño)
    {
        _size = tamaño;
        InvokeChangeSize();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos del cambio de tamaño y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeSize()
    {
        ChangeSizeEvt?.Invoke(this, _size);
    }

    #endregion Tamaño de letra
}


public class WoInputAlertView
{
    /// <summary>
    /// Informacion que contendra la alerta del componente.
    /// </summary>
    private string _value = string.Empty;

    #region Agregar Alerta

    /// <summary>
    /// Controlador de eventos para enviar el valor de la alerta a la alerta interna.
    /// </summary>
    public event EventHandler<string>? SetAlertValueEvt;

    /// <summary>
    /// Permite asignar el valor de la alerta del input.
    /// </summary>
    /// <param name="value"></param>
    public void AgregarAlerta(string value)
    {
        _value = value;
        SetAlertValueEvt?.Invoke(this, value);
    }

    #endregion Agregar Alerta

    #region Limpiar Alertas

    /// <summary>
    /// Controlador de eventos para limpiar las alertas del componente.
    /// </summary>
    public event EventHandler? ClearAlertsEvt;

    /// <summary>
    /// Metodo visible para el usuario para limpiar las alertas.
    /// </summary>
    public void LimpiarAlertas()
    {
        ClearAlertsEvt?.Invoke(this, EventArgs.Empty);
    }

    #endregion Limpiar Alertas
}


public class WoFormToolbarView
{
    #region Des/Habilitar navegación

    /// <summary>
    /// Indica si el control esta habilitado.
    /// </summary>
    private bool _navigationStatus = true;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar si el componente esta habilitado o des habilitado.
    /// </summary>
    public event EventHandler<bool>? ChangeNavigationEnabledEvt;

    /// <summary>
    /// Método con los que interactúa el usuario desde el editor para
    /// habilitar o deshabilitar el control.
    /// </summary>
    /// <param name="NavegacionHabilitada">Define si la navegación se habilita o no</param>
    public void EstadoNavegacion(bool NavegacionHabilitada)
    {
        _navigationStatus = NavegacionHabilitada;
        InvokeChangeNavigationEnabled();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos de la 
    /// habilitación del control y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeNavigationEnabled()
    {
        ChangeNavigationEnabledEvt?.Invoke(this, _navigationStatus);
    }

    #endregion Des/Habilitar navegación

    #region Des/Habilitar botones navegación

    #region First

    /// <summary>
    /// Indica si el control esta habilitado.
    /// </summary>
    private bool _firstStatus = true;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar si el componente esta habilitado o des habilitado.
    /// </summary>
    public event EventHandler<bool>? ChangeBtnFirstEnabledEvt;

    /// <summary>
    /// Método con los que interactúa el usuario desde el editor para
    /// habilitar o deshabilitar el control.
    /// </summary>
    /// <param name="NavegacionHabilitada">Define si la navegación se habilita o no</param>
    public void EstadoBtnPrimeroHabilitado(bool estado)
    {
        _firstStatus = estado;
        InvokeChangeBtnFirstEnabled();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos de la 
    /// habilitación del control y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeBtnFirstEnabled()
    {
        ChangeBtnFirstEnabledEvt?.Invoke(this, _firstStatus);
    }

    #endregion First

    #region Prior

    /// <summary>
    /// Indica si el control esta habilitado.
    /// </summary>
    private bool _priorStatus = true;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar si el componente esta habilitado o des habilitado.
    /// </summary>
    public event EventHandler<bool>? ChangeBtnPriorEnabledEvt;

    /// <summary>
    /// Método con los que interactúa el usuario desde el editor para
    /// habilitar o deshabilitar el control.
    /// </summary>
    /// <param name="NavegacionHabilitada">Define si la navegación se habilita o no</param>
    public void EstadoBtnAnteriorHabilitado(bool estado)
    {
        _priorStatus = estado;
        InvokeChangeBtnPriorEnabled();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos de la 
    /// habilitación del control y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeBtnPriorEnabled()
    {
        ChangeBtnPriorEnabledEvt?.Invoke(this, _priorStatus);
    }

    #endregion Prior

    #region Next

    /// <summary>
    /// Indica si el control esta habilitado.
    /// </summary>
    private bool _nextStatus = true;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar si el componente esta habilitado o des habilitado.
    /// </summary>
    public event EventHandler<bool>? ChangeBtnNextEnabledEvt;

    /// <summary>
    /// Método con los que interactúa el usuario desde el editor para
    /// habilitar o deshabilitar el control.
    /// </summary>
    /// <param name="NavegacionHabilitada">Define si la navegación se habilita o no</param>
    public void EstadoBtnSiguienteHabilitado(bool estado)
    {
        _nextStatus = estado;
        InvokeChangeBtnNextEnabled();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos de la 
    /// habilitación del control y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeBtnNextEnabled()
    {
        ChangeBtnNextEnabledEvt?.Invoke(this, _nextStatus);
    }

    #endregion Next

    #region Last

    /// <summary>
    /// Indica si el control esta habilitado.
    /// </summary>
    private bool _lastStatus = true;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar si el componente esta habilitado o des habilitado.
    /// </summary>
    public event EventHandler<bool>? ChangeBtnLastEnabledEvt;

    /// <summary>
    /// Método con los que interactúa el usuario desde el editor para
    /// habilitar o deshabilitar el control.
    /// </summary>
    /// <param name="NavegacionHabilitada">Define si la navegación se habilita o no</param>
    public void EstadoBtnUltimoHabilitado(bool estado)
    {
        _lastStatus = estado;
        InvokeChangeBtnLastEnabled();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos de la 
    /// habilitación del control y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeBtnLastEnabled()
    {
        ChangeBtnLastEnabledEvt?.Invoke(this, _lastStatus);
    }

    #endregion Last

    #endregion Des/Habilitar botones navegación



    #region Des/Habilitar Combo transiciones

    /// <summary>
    /// Indica si el control esta habilitado.
    /// </summary>
    private bool _transitionComboStatus = true;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar si el componente esta habilitado o des habilitado.
    /// </summary>
    public event EventHandler<bool>? ChangeTransitionEnabledEvt;

    /// <summary>
    /// Método con los que interactúa el usuario desde el editor para
    /// habilitar o deshabilitar el control.
    /// </summary>
    public void EstadoBarraDeTransicion(bool estado)
    {
        _transitionComboStatus = estado;
        InvokeChangeTransitionComboEnabled();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos de la 
    /// habilitación del control y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeTransitionComboEnabled()
    {
        ChangeTransitionEnabledEvt?.Invoke(this, _transitionComboStatus);
    }

    #endregion Des/Habilitar Combo transiciones

    #region Des/Habilitar botones transiciones

    /// <summary>
    /// Indica si el control esta habilitado.
    /// </summary>
    private bool _transitionButtonsStatus = true;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar si el componente esta habilitado o des habilitado.
    /// </summary>
    public event EventHandler<bool>? ChangeTransitionButtonsEnabledEvt;

    /// <summary>
    /// Método con los que interactúa el usuario desde el editor para
    /// habilitar o deshabilitar el control.
    /// </summary>
    /// <param name="estado">Define si los botones de acción de las transiciones se habilitan.</param>
    public void EstadoBotonesDeTransicion(bool estado)
    {
        _transitionButtonsStatus = estado;
        InvokeChangeTransitionButtonEnabled();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos de la 
    /// habilitación del control y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeTransitionButtonEnabled()
    {
        ChangeTransitionButtonsEnabledEvt?.Invoke(this, _transitionButtonsStatus);
    }

    #endregion Des/Habilitar botones transiciones

    #region Des/Habilitar botón de eliminar

    /// <summary>
    /// Indica si el control esta habilitado.
    /// </summary>
    private bool _deleteButtonsStatus = true;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar si el componente esta habilitado o des habilitado.
    /// </summary>
    public event EventHandler<bool>? ChangeDeleteButtonsEnabledEvt;

    /// <summary>
    /// Método con los que interactúa el usuario desde el editor para
    /// habilitar o deshabilitar el control.
    /// </summary>
    /// <param name="estado">Define si los botones de acción de delete se habilitan.</param>
    public void EstadoBotonesDeDelete(bool estado)
    {
        _deleteButtonsStatus = estado;
        InvokeChangeDeleteButtonEnabled();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos de la 
    /// habilitación del control y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeDeleteButtonEnabled()
    {
        ChangeDeleteButtonsEnabledEvt?.Invoke(this, _deleteButtonsStatus);
    }

    #endregion Des/Habilitar botón de eliminar

    #region Actualización general del render del componente

    /// <summary>
    /// Actualiza el renderizado del componente para que 
    /// se le pasen los datos de la view al componente.
    /// Nota: Hay que realizar esto luego de suscribir los eventos
    /// puesto que los usara para actualizar el renderizado.
    /// </summary>
    public void ActualizarComponente()
    {
        InvokeChangeTransitionButtonEnabled();
        InvokeChangeTransitionComboEnabled();
        InvokeChangeNavigationEnabled();
    }

    #endregion Actualización general del render del componente
}


public class WoShareButtonView
{
    #region Des/Habilitar Botón

    /// <summary>
    /// Indica si el control esta habilitado.
    /// </summary>
    private bool _shareStatus = true;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar si el componente esta habilitado o des habilitado.
    /// </summary>
    public event EventHandler<bool>? ChangeShareEnabledEvt;

    /// <summary>
    /// Método con los que interactúa el usuario desde el editor para
    /// habilitar o deshabilitar el control.
    /// </summary>
    /// <param name="NavegacionHabilitada">Define si la navegación se habilita o no</param>
    public void EstadoHabilitado(bool estadoHabilitado)
    {
        _shareStatus = estadoHabilitado;
        InvokeChangeShareEnabled();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos de la 
    /// habilitación del control y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeShareEnabled()
    {
        ChangeShareEnabledEvt?.Invoke(this, _shareStatus);
    }

    #endregion Des/Habilitar Botón
}


public class WoFormAlertView
{
	#region Variables globales base

	/// <summary>
	/// Lista de alertas que no se pudieron agregar al componente.
	/// </summary>
	private List<WoFormAlertModel> _alerts = new List<WoFormAlertModel>();

	/// <summary>
	/// Permite la implementación de mutex sobre la clase para proteger algoritmos.
	/// </summary>
	private static readonly object _lockObject = new object();

	#endregion Variables globales base

	#region Agregar alerta

	/// <summary>
	/// Controlador de eventos al cual suscribir el método para agregar
	/// alertas del componente.
	/// </summary>
	public EventHandler<WoFormAlertModel>? AddAlertEvt;

	/// <summary>
	/// Método para agregar alertas por parte del código del usuario o
	/// de por parte de algún otro componente.
	/// </summary>
	/// <param name="mensaje"></param>
	/// <param name="tipoDeAlerta"></param>
	/// <param name="siempreEnPantalla"></param>
	/// <param name="tiempo"></param>
	public void AgregarAlerta(
		string mensaje,
		eTipoDeAlerta tipoDeAlerta = eTipoDeAlerta.Error,
		bool siempreEnPantalla = false,
		int tiempo = 5)
	{
		lock (_lockObject)
		{
			if (_alerts.Where(x => x.Message == mensaje).FirstOrDefault() == null)
			{
				WoFormAlertModel alert = new WoFormAlertModel(
					message: mensaje,
					alertType: tipoDeAlerta,
					alwaysOnDisplay: siempreEnPantalla,
					time: tiempo
				);

				alert.CloseAlertEvt += (sender, e) =>
				{
					RemoverAlerta(e);
				};

				_alerts.Add(alert);

				if (AddAlertEvt != null)
				{
					AddAlertEvt.Invoke(this, alert);
				}
			}
		}
	}

	#endregion Agregar alerta

	#region Remover alerta

	/// <summary>
	/// Controlador de eventos al que se suscribirá el método para
	/// remover las alertas dentro del componente.
	/// </summary>
	public EventHandler<string>? RemoveAlertEvt;

	/// <summary>
	/// Método que puede detonarse desde el código del usuario o
	/// desde la parcial para remover alertas.
	/// Detona el controlador de eventos para remover alertas.
	/// </summary>
	/// <param name="mensaje"></param>
	public void RemoverAlerta(string mensaje)
	{
		lock (_lockObject)
		{
			WoFormAlertModel? alert = _alerts.Where(x => x.Message == mensaje).FirstOrDefault();
			if (alert != null)
			{
				_alerts.Remove(alert);
			}
			RemoveAlertEvt?.Invoke(this, mensaje);
		}
	}

	#endregion Remover alerta

	#region Limpiar todo

	/// <summary>
	/// Delegado a partir del cual se creara el controlador de eventos
	/// para métodos sin parámetros.
	/// </summary>
	public delegate void EventHandlerVoid();
	/// <summary>
	/// Controlador de eventos creado a partir del delegado.
	/// Se le suscribirá el método para limpiar las alertas en el componente.
	/// </summary>
	public EventHandlerVoid? CleanAlertsEvt;

	/// <summary>
	/// Método que permite eliminar todas las alertas desde el código del usuario
	/// o desde la parcial.
	/// </summary>
	public void RemoverTodasLasAlertas()
	{
		lock (_lockObject)
		{
			_alerts.Clear();
			CleanAlertsEvt?.Invoke();
		}
	}

	#endregion Limpiar todo

	#region Sincronización

	/// <summary>
	/// Se ocupa de actualizar el componente con la lista
	/// de la vista.
	/// </summary>
	public void ActualizarComponente()
	{
		if (_alerts.Count > 0)
		{
			if (AddAlertEvt != null)
			{
				foreach (var alert in _alerts)
				{
					AddAlertEvt?.Invoke(this, alert);
				}
			}
		}
	}

	#endregion Sincronización
}

public class WoFormAlertModel
    {
        #region Variables globales

        /// <summary>
        /// Texto que contendrá la alerta.
        /// </summary>
        public string Message = string.Empty;

        /// <summary>
        /// Tiempo que permanece la alerta
        /// </summary>
        private int _time { get; set; } = 5;

        /// <summary>
        /// Bandera para saver si se mantiene siempre hasta que el usuario
        /// u otro evento la cierre.
        /// </summary>
        private bool _alwaysOnDisplay = false;

		#endregion Variables globales

		#region Tipo de alerta

		/// <summary>
		/// Tipo de alerta.
		/// </summary>
		private eTipoDeAlerta AlertType
		{
			get;
			set;
			
		}
		/// <summary>
		/// Permite operar con el tipo de alerta sin el parámetro.
		/// </summary>
		private eTipoDeAlerta _alertType;

		/// <summary>
		/// Representa la clase CSS con el diseño de la alerta.
		/// </summary>
		private string _alertTypeClass = string.Empty;

		#endregion Tipo de alerta

		#region Constructores

		/// <summary>
		/// Como todas las propiedades son privadas se bloquea el constructor vació.
		/// </summary>
		private WoFormAlertModel() { }

        /// <summary>
        /// Constructor principal para la generación de alertas.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="alertType"></param>
        /// <param name="alwaysOnDisplay"></param>
        /// <param name="time"></param>
        public WoFormAlertModel(string message,
            eTipoDeAlerta alertType = eTipoDeAlerta.Error,
            bool alwaysOnDisplay = false,
            int time = 5
        )
        {
        }

        #endregion Constructores

        #region Timer

        /// <summary>
        /// Controlador de eventos al cual suscribir el evento para sacar la alerta de la lista.
        /// </summary>
        public EventHandler<string>? CloseAlertEvt;

        /// <summary>
        /// Método suscrito al controlador de eventos del timer.
        /// Detiene el timer y detona el EventCallBack.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void CloseAlert(object? sender, EventArgs args)
        {
        }

        /// <summary>
        /// Inicia el timer en caso de que no sea siempre en la pantalla.
        /// </summary>
        public void StartTimer()
        {
        }

        /// <summary>
        /// Detiene y saca de memoria el timer.
        /// </summary>
        public void StopTimer()
        {
        }

        #endregion Timer
    }

public class WoDetailGridView
{
    #region Habilitar/deshabilitar edición

    /// <summary>
    /// Indica si el control esta habilitado.
    /// </summary>
    private bool _editionModeStatus = false;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar si el componente esta habilitado o des habilitado.
    /// </summary>
    public event EventHandler<bool>? ChangeEditionModeEvt;

    public void EstadoHabilitado(bool estado)
    {
        _editionModeStatus = estado;
        InvokeChangeEditionMode();
    }

    private void InvokeChangeEditionMode() => ChangeEditionModeEvt?.Invoke(this, _editionModeStatus);

    #endregion Habilitar/deshabilitar edición

    #region Customización

    #region Header

    #region Color de Fondo

    private eContainerItemColor _headerBackgroundColor = eContainerItemColor.Default;

    public EventHandler<eContainerItemColor>? ChangeHeaderBackgroundColorEvt;

    public void ColorDeFondeDeEncabezado(eContainerItemColor color)
    {
        _headerBackgroundColor = color;
        InvokeChangeHeaderBGColor();
    }

    private void InvokeChangeHeaderBGColor() => ChangeHeaderBackgroundColorEvt?.Invoke(this, _headerBackgroundColor);

    #endregion Color de Fondo

    #region Color de Letra

    /// <summary>
    /// Representa el calor del color de la letra.
    /// </summary>
    private eTextColor _headerFontColor = eTextColor.FontDefault;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el color de letra.
    /// </summary>
    public event EventHandler<eTextColor>? ChangeHeaderFontColorEvt;

    /// <summary>
    /// Cambiar color de la letra desde el script o otro lado.
    /// </summary>
    /// <param name="newColor"></param>
    public void ColorDeLetraDeEncabezado(eTextColor color)
    {
        _headerFontColor = color;
        InvokeChangeHeaderFontColor();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeHeaderFontColor()
    {
        ChangeHeaderFontColorEvt?.Invoke(this, _headerFontColor);
    }

    #endregion Color de Letra

    #region Negrita

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextWeight _headerFontWeight = eTextWeight.Normal;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextWeight>? ChangeHeaderFontWeightEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void GrosorDeLetraDeEncabezado(eTextWeight negrita)
    {
        _headerFontWeight = negrita;
        InvokeChangeHeaderFontWeight();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeHeaderFontWeight()
    {
        ChangeHeaderFontWeightEvt?.Invoke(this, _headerFontWeight);
    }

    #endregion Negrita

    #region Italica

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextItalic _headerFontItalic = eTextItalic.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextItalic>? ChangeHeaderFontItalicEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void EncabezadoEnItalica(eTextItalic italica)
    {
        _headerFontItalic = italica;
        InvokeChangeHeaderFontItalic();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeHeaderFontItalic()
    {
        ChangeHeaderFontItalicEvt?.Invoke(this, _headerFontItalic);
    }

    #endregion Italica

    #region Tachado/Subrayado

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextDecoration _headerFontDecoration = eTextDecoration.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextDecoration>? ChangeHeaderFontDecorationEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void DecoracionDeLetraDeTitulo(eTextDecoration decoracion)
    {
        _headerFontDecoration = decoracion;
        InvokeChangeHeaderFontDecoration();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeHeaderFontDecoration()
    {
        ChangeHeaderFontDecorationEvt?.Invoke(this, _headerFontDecoration);
    }

    #endregion Tachado/Subrayado

    #region Tamaño de letra

    /// <summary>
    /// Representa el valor del tamaño del control.
    /// </summary>
    private eItemSize _headerFontSize = eItemSize.Small;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar el tamaño del componente.
    /// </summary>
    public event EventHandler<eItemSize>? ChangeHeaderFontSizeEvt;

    /// <summary>
    /// Métodos con los que interactue el usuario desde el editor para modificar el
    /// tamaño del control.
    /// </summary>
    public void TamañoDeLetraDeEncabezado(eItemSize tamaño)
    {
        _headerFontSize = tamaño;
        InvokeChangeHeaderFontSize();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos del cambio de tamaño y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeHeaderFontSize()
    {
        ChangeHeaderFontSizeEvt?.Invoke(this, _headerFontSize);
    }

    #endregion Tamaño de letra

    #endregion Header

    #region Filas

    #region Color de Fondo 1

    private eContainerItemColor _rowsColor1 = eContainerItemColor.Default;

    public EventHandler<eContainerItemColor>? ChangeRowsBackgroundColor1Evt;

    public void ColorDeFondeDeFilas1(eContainerItemColor color)
    {
        _rowsColor1 = color;
        InvokeChangeRowsBGColor1();
    }

    private void InvokeChangeRowsBGColor1() => ChangeRowsBackgroundColor1Evt?.Invoke(this, _rowsColor1);

    #endregion Color de Fondo 1

    #region Color de Fondo 2

    private eContainerItemColor? _rowsColor2 = eContainerItemColor.Default;

    public EventHandler<eContainerItemColor?>? ChangeRowsBackgroundColor2Evt;

    public void ColorDeFondeDeFilas2(eContainerItemColor? color)
    {
        //if(color != null)
        _rowsColor2 = color;
        InvokeChangeRowsBGColor2();
    }

    private void InvokeChangeRowsBGColor2() => ChangeRowsBackgroundColor2Evt?.Invoke(this, _rowsColor2);

    #endregion Color de Fondo 2

    #region Color de Letra

    /// <summary>
    /// Representa el calor del color de la letra.
    /// </summary>
    private eTextColor _rowsFontColor = eTextColor.FontDefault;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el color de letra.
    /// </summary>
    public event EventHandler<eTextColor>? ChangeRowsFontColorEvt;

    /// <summary>
    /// Cambiar color de la letra desde el script o otro lado.
    /// </summary>
    /// <param name="newColor"></param>
    public void ColorDeLetraDeFilas(eTextColor color)
    {
        _rowsFontColor = color;
        InvokeChangeRowsFontColor();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeRowsFontColor()
    {
        ChangeRowsFontColorEvt?.Invoke(this, _rowsFontColor);
    }

    #endregion Color de Letra

    #region Negrita

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextWeight _rowsFontWeight = eTextWeight.Normal;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextWeight>? ChangeRowsFontWeightEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void GrosorDeLetraDeFilas(eTextWeight negrita)
    {
        _rowsFontWeight = negrita;
        InvokeChangeRowsFontWeight();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeRowsFontWeight()
    {
        ChangeRowsFontWeightEvt?.Invoke(this, _rowsFontWeight);
    }

    #endregion Negrita

    #region Italica

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextItalic _rowsFontItalic = eTextItalic.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextItalic>? ChangeRowsFontItalicEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void FilasEnItalica(eTextItalic italica)
    {
        _rowsFontItalic = italica;
        InvokeChangeRowsFontItalic();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeRowsFontItalic()
    {
        ChangeRowsFontItalicEvt?.Invoke(this, _rowsFontItalic);
    }

    #endregion Italica

    #region Tachado/Subrayado

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextDecoration _rowsFontDecoration = eTextDecoration.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextDecoration>? ChangeRowsFontDecorationEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void DecoracionDeLetraDeFilas(eTextDecoration decoracion)
    {
        _rowsFontDecoration = decoracion;
        InvokeChangeRowsFontDecoration();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeRowsFontDecoration()
    {
        ChangeRowsFontDecorationEvt?.Invoke(this, _rowsFontDecoration);
    }

    #endregion Tachado/Subrayado

    #region Tamaño de letra

    /// <summary>
    /// Representa el valor del tamaño del control.
    /// </summary>
    private eItemSize _RowsFontSize = eItemSize.Small;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar el tamaño del componente.
    /// </summary>
    public event EventHandler<eItemSize>? ChangeRowsFontSizeEvt;

    /// <summary>
    /// Métodos con los que interactue el usuario desde el editor para modificar el
    /// tamaño del control.
    /// </summary>
    public void TamañoDeLetraDeFilas(eItemSize tamaño)
    {
        _RowsFontSize = tamaño;
        InvokeChangeRowsFontSize();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos del cambio de tamaño y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeRowsFontSize()
    {
        ChangeRowsFontSizeEvt?.Invoke(this, _RowsFontSize);
    }

    #endregion Tamaño de letra

    #endregion Filas

    #endregion Customización

    #region Actualización general del render del componente

    /// <summary>
    /// Actualiza el renderizado del componente para que 
    /// se le pasen los datos de la view al componente.
    /// Nota: Hay que realizar esto luego de suscribir los eventos
    /// puesto que los usara para actualizar el renderizado.
    /// </summary>
    public void ActualizarComponente()
    {
        InvokeChangeEditionMode();

        InvokeChangeHeaderFontColor();
        InvokeChangeHeaderFontSize();
        InvokeChangeHeaderFontItalic();
        InvokeChangeHeaderFontDecoration();
        InvokeChangeHeaderFontWeight();
        InvokeChangeHeaderBGColor();

        InvokeChangeRowsFontColor();
        InvokeChangeRowsFontSize();
        InvokeChangeRowsFontItalic();
        InvokeChangeRowsFontDecoration();
        InvokeChangeRowsFontWeight();
        InvokeChangeRowsBGColor1();
        InvokeChangeRowsBGColor2();
    }

    #endregion Actualización general del render del componente
}


public class IJSRuntime
    {
        public void InvokeAsync<T>(string NombreMetodo, T parametros)
        {
        }
        public void InvokeAsync<T>(string NombreMetodo, T parametro1, T parametro2)
        {
        }
        public void InvokeAsync<T>(string NombreMetodo, T parametro1, T parametro2, T parametro3)
        {
        }

        public void InvokeVoidAsync(string NombreMetodo, string parametros)
        {
        }
        public void InvokeVoidAsync(string NombreMetodo, string parametro1, string parametro2)
        {
        }
        public void InvokeVoidAsync(string NombreMetodo, string parametro1, string parametro2, byte[] parametro3)
        {
        }
    }

}
