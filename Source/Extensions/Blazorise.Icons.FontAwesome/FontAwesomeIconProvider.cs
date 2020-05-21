﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazorise.Providers;
#endregion

namespace Blazorise.Icons.FontAwesome
{
    class FontAwesomeIconProvider : BaseIconProvider
    {
        #region Members

        private static Dictionary<IconName, string> names = new Dictionary<IconName, string>
        {
            { IconName.Add, "fa-plus" },
            { IconName.Adjust, "fa-adjust" },
            { IconName.AlignCenter, "fa-align-center" },
            { IconName.AlignJustify, "fa-align-justify" },
            { IconName.AlignLeft, "fa-align-left" },
            { IconName.AlignRight, "fa-align-right" },
            { IconName.AngleDown, "fa-angle-down" },
            { IconName.AngleLeft, "fa-angle-left" },
            { IconName.AngleRight, "fa-angle-right" },
            { IconName.AngleUp, "fa-angle-up" },
            { IconName.Archive, "fa-archive" },
            { IconName.ArrowAltCircleDown, "fa-arrow-alt-circle-down" },
            { IconName.ArrowDown, "fa-arrow-down" },
            { IconName.ArrowLeft, "fa-arrow-left" },
            { IconName.ArrowRight, "fa-arrow-right" },
            { IconName.ArrowUp, "fa-arrow-up" },
            { IconName.Baby, "fa-baby" },
            { IconName.BabyCarriage, "fa-baby-carriage" },
            { IconName.Backspace, "fa-backspace" },
            { IconName.Backward, "fa-backward" },
            { IconName.BalanceScale, "fa-balance-scale" },
            { IconName.Ban, "fa-ban" },
            { IconName.BandAid, "fa-band-aid" },
            { IconName.Bars, "fa-bars" },
            { IconName.BatteryFull, "fa-battery-full" },
            { IconName.Bell, "fa-bell" },
            { IconName.BellSlash, "fa-bell-slash" },
            { IconName.Biking, "fa-biking" },
            { IconName.BirthdayCake, "fa-birthday-cake" },
            { IconName.Bold, "fa-bold" },
            { IconName.Bolt, "fa-bolt" },
            { IconName.Book, "fa-book" },
            { IconName.Bookmark, "fa-bookmark" },
            { IconName.BookReader, "fa-book-reader" },
            { IconName.BorderAll, "fa-border-all" },
            { IconName.BorderNone, "fa-border-none" },
            { IconName.BorderStyle, "fa-border-style" },
            { IconName.Briefcase, "fa-briefcase" },
            { IconName.Brush, "fa-brush" },
            { IconName.Bug, "fa-bug" },
            { IconName.Building, "fa-building" },
            { IconName.Bus, "fa-bus" },
            { IconName.CalendarCheck, "fa-calendar-check" },
            { IconName.CalendarDay, "fa-calendar-day" },
            { IconName.CalendarTimes, "fa-calendar-times" },
            { IconName.CalendarWeek, "fa-calendar-week" },
            { IconName.Camera, "fa-camera" },
            { IconName.CameraRetro, "fa-camera-retro" },
            { IconName.Car, "fa-car" },
            { IconName.CaretSquareRight, "fa-caret-square-right" },
            { IconName.CartPlus, "fa-cart-plus" },
            { IconName.Chair, "fa-chair" },
            { IconName.ChartPie, "fa-chart-pie" },
            { IconName.Check, "fa-check" },
            { IconName.CheckCircle, "fa-check-circle" },
            { IconName.CheckDouble, "fa-check-double" },
            { IconName.CheckSquare, "fa-check-square" },
            { IconName.ChevronLeft, "fa-chevron-left" },
            { IconName.ChevronRight, "fa-chevron-right" },
            { IconName.Circle, "fa-circle" },
            { IconName.City, "fa-city" },
            { IconName.Clear, "fa-eraser" },
            { IconName.ClinicMedical, "fa-clinic-medical" },
            { IconName.Clock, "fa-clock" },
            { IconName.ClosedCaptioning, "fa-closed-captioning" },
            { IconName.Cloud, "fa-cloud" },
            { IconName.CloudDownloadAlt, "fa-cloud-download-alt" },
            { IconName.CloudUploadAlt, "fa-cloud-upload-alt" },
            { IconName.Cocktail, "fa-cocktail" },
            { IconName.Code, "fa-code" },
            { IconName.Coffee, "fa-coffee" },
            { IconName.Comment, "fa-comment" },
            { IconName.CommentAlt, "fa-comment-alt" },
            { IconName.Comments, "fa-comments" },
            { IconName.CompactDisc, "fa-compact-disc" },
            { IconName.Compass, "fa-compass" },
            { IconName.Compress, "fa-compress" },
            { IconName.Copyright, "fa-copyright" },
            { IconName.CreditCard, "fa-credit-card" },
            { IconName.Crop, "fa-crop" },
            { IconName.Dashboard, "fa-columns" },
            { IconName.Delete, "fa-trash" },
            { IconName.Desktop, "fa-desktop" },
            { IconName.Dice, "fa-dice" },
            { IconName.Directions, "fa-directions" },
            { IconName.Dog, "fa-dog" },
            { IconName.DollarSign, "fa-dollar-sign" },
            { IconName.DotCircle, "fa-dot-circle" },
            { IconName.Download, "fa-download" },
            { IconName.Dumbbell, "fa-dumbbell" },
            { IconName.Edit, "fa-edit" },
            { IconName.Eject, "fa-eject" },
            { IconName.Ethernet, "fa-ethernet" },
            { IconName.EuroSign, "fa-euro-sign" },
            { IconName.Exclamation, "fa-exclamation" },
            { IconName.ExclamationCircle, "fa-exclamation-circle" },
            { IconName.ExclamationTriangle, "fa-exclamation-triangle" },
            { IconName.Expand, "fa-expand" },
            { IconName.ExpandArrowsAlt, "fa-expand-arrows-alt" },
            { IconName.ExpandLess, "fa-chevron-up" },
            { IconName.ExpandMore, "fa-chevron-down" },
            { IconName.ExternalLinkSquareAlt, "fa-external-link-square-alt" },
            { IconName.Eye, "fa-eye" },
            { IconName.EyeSlash, "fa-eye-slash" },
            { IconName.FastForward, "fa-fast-forward" },
            { IconName.FileAlt, "fa-file-alt" },
            { IconName.FileDownload, "fa-file-download" },
            { IconName.FilePdf, "fa-file-pdf" },
            { IconName.FileUpload, "fa-file-upload" },
            { IconName.Film, "fa-film" },
            { IconName.Filter, "fa-filter" },
            { IconName.Fingerprint, "fa-fingerprint" },
            { IconName.Fire, "fa-fire" },
            { IconName.Flag, "fa-flag" },
            { IconName.Folder, "fa-folder" },
            { IconName.FolderOpen, "fa-folder-open" },
            { IconName.FolderPlus, "fa-folder-plus" },
            { IconName.Forward, "fa-forward" },
            { IconName.Frown, "fa-frown" },
            { IconName.FrownOpen, "fa-frown-open" },
            { IconName.Gamepad, "fa-gamepad" },
            { IconName.GasPump, "fa-gas-pump" },
            { IconName.Gavel, "fa-gavel" },
            { IconName.Gift, "fa-gift" },
            { IconName.Grin, "fa-grin" },
            { IconName.GripLines, "fa-grip-lines" },
            { IconName.HandPaper, "fa-hand-paper" },
            { IconName.HandsHelping, "fa-hands-helping" },
            { IconName.Headphones, "fa-headphones" },
            { IconName.Headset, "fa-headset" },
            { IconName.Heart, "fa-heart" },
            { IconName.Highlighter, "fa-highlighter" },
            { IconName.History, "fa-history" },
            { IconName.Home, "fa-home" },
            { IconName.Hospital, "fa-hospital" },
            { IconName.Hotel, "fa-hotel" },
            { IconName.HotTub, "fa-hot-tub" },
            { IconName.Hourglass, "fa-hourglass" },
            { IconName.IdCard, "fa-id-card" },
            { IconName.Image, "fa-image" },
            { IconName.Images, "fa-images" },
            { IconName.Inbox, "fa-inbox" },
            { IconName.Indent, "fa-indent" },
            { IconName.Infinity, "fa-infinity" },
            { IconName.Info, "fa-info" },
            { IconName.InfoCircle, "fa-info-circle" },
            { IconName.Italic, "fa-italic" },
            { IconName.Key, "fa-key" },
            { IconName.Keyboard, "fa-keyboard" },
            { IconName.Language, "fa-language" },
            { IconName.Laptop, "fa-laptop" },
            { IconName.LaptopCode, "fa-laptop-code" },
            { IconName.Laugh, "fa-laugh" },
            { IconName.LayerGroup, "fa-layer-group" },
            { IconName.Lightbulb, "fa-lightbulb" },
            { IconName.Link, "fa-link" },
            { IconName.List, "fa-list" },
            { IconName.ListOl, "fa-list-ol" },
            { IconName.ListUl, "fa-list-ul" },
            { IconName.LocationArrow, "fa-location-arrow" },
            { IconName.Lock, "fa-lock" },
            { IconName.LockOpen, "fa-lock-open" },
            { IconName.Mail, "fa-envelope" },
            { IconName.Map, "fa-map" },
            { IconName.MapMarker, "fa-map-marker" },
            { IconName.MapMarkerAlt, "fa-map-marker-alt" },
            { IconName.Memory, "fa-memory" },
            { IconName.Microphone, "fa-microphone" },
            { IconName.MicrophoneSlash, "fa-microphone-slash" },
            { IconName.MinusCircle, "fa-minus-circle" },
            { IconName.MinusSquare, "fa-minus-square" },
            { IconName.MoneyBillAlt, "fa-money-bill-alt" },
            { IconName.MoreHorizontal, "fa-ellipsis-h" },
            { IconName.MoreVertical, "fa-ellipsis-v" },
            { IconName.Motorcycle, "fa-motorcycle" },
            { IconName.Mouse, "fa-mouse" },
            { IconName.Music, "fa-music" },
            { IconName.PaintBrush, "fa-paint-brush" },
            { IconName.PaintRoller, "fa-paint-roller" },
            { IconName.Palette, "fa-palette" },
            { IconName.Paperclip, "fa-paperclip" },
            { IconName.PaperPlane, "fa-paper-plane" },
            { IconName.Parking, "fa-parking" },
            { IconName.Pause, "fa-pause" },
            { IconName.PauseCircle, "fa-pause-circle" },
            { IconName.Pen, "fa-pen" },
            { IconName.Phone, "fa-phone" },
            { IconName.PhoneAlt, "fa-phone-alt" },
            { IconName.PizzaSlice, "fa-pizza-slice" },
            { IconName.Plane, "fa-plane" },
            { IconName.PlaneArrival, "fa-plane-arrival" },
            { IconName.PlaneDeparture, "fa-plane-departure" },
            { IconName.Play, "fa-play" },
            { IconName.PlayCircle, "fa-play-circle" },
            { IconName.Plug, "fa-plug" },
            { IconName.PlusCircle, "fa-plus-circle" },
            { IconName.PlusSquare, "fa-plus-square" },
            { IconName.Poll, "fa-poll" },
            { IconName.Portrait, "fa-portrait" },
            { IconName.Print, "fa-print" },
            { IconName.PuzzlePiece, "fa-puzzle-piece" },
            { IconName.QuestionCircle, "fa-question-circle" },
            { IconName.QuoteRight, "fa-quote-right" },
            { IconName.Random, "fa-random" },
            { IconName.Receipt, "fa-receipt" },
            { IconName.Redo, "fa-redo" },
            { IconName.Remove, "fa-minus" },
            { IconName.RemoveFormat, "fa-remove-format" },
            { IconName.Reply, "fa-reply" },
            { IconName.ReplyAll, "fa-reply-all" },
            { IconName.Restroom, "fa-restroom" },
            { IconName.Rss, "fa-rss" },
            { IconName.RulerHorizontal, "fa-ruler-horizontal" },
            { IconName.Running, "fa-running" },
            { IconName.Satellite, "fa-satellite" },
            { IconName.Save, "fa-save" },
            { IconName.School, "fa-school" },
            { IconName.SdCard, "fa-sd-card" },
            { IconName.Search, "fa-search" },
            { IconName.SearchMinus, "fa-search-minus" },
            { IconName.SearchPlus, "fa-search-plus" },
            { IconName.Seedling, "fa-seedling" },
            { IconName.Server, "fa-server" },
            { IconName.Shapes, "fa-shapes" },
            { IconName.Share, "fa-share" },
            { IconName.ShareAlt, "fa-share-alt" },
            { IconName.ShieldAlt, "fa-shield-alt" },
            { IconName.Ship, "fa-ship" },
            { IconName.ShoppingBag, "fa-shopping-bag" },
            { IconName.ShoppingBasket, "fa-shopping-basket" },
            { IconName.ShoppingCart, "fa-shopping-cart" },
            { IconName.ShuttleVan, "fa-shuttle-van" },
            { IconName.SimCard, "fa-sim-card" },
            { IconName.SliderHorizontal, "fa-sliders-h" },
            { IconName.Smartphone, "fa-mobile" },
            { IconName.Smile, "fa-smile" },
            { IconName.Smoking, "fa-smoking" },
            { IconName.SmokingBan, "fa-smoking-ban" },
            { IconName.Sms, "fa-sms" },
            { IconName.Snowflake, "fa-snowflake" },
            { IconName.Sort, "fa-sort" },
            { IconName.SortAlphaDown, "fa-sort-alpha-down" },
            { IconName.SortAmountDownAlt, "fa-sort-amount-down-alt" },
            { IconName.SortDown, "fa-sort-down" },
            { IconName.SortUp, "fa-sort-up" },
            { IconName.Spa, "fa-spa" },
            { IconName.SpellCheck, "fa-spell-check" },
            { IconName.Square, "fa-square" },
            { IconName.Star, "fa-star" },
            { IconName.StarHalf, "fa-star-half" },
            { IconName.StepBackward, "fa-step-backward" },
            { IconName.StepForward, "fa-step-forward" },
            { IconName.StickyNote, "fa-sticky-note" },
            { IconName.Stop, "fa-stop" },
            { IconName.Store, "fa-store" },
            { IconName.StoreAlt, "fa-store-alt" },
            { IconName.Stream, "fa-stream" },
            { IconName.StreetView, "fa-street-view" },
            { IconName.Strikethrough, "fa-strikethrough" },
            { IconName.Subway, "fa-subway" },
            { IconName.Suitcase, "fa-suitcase" },
            { IconName.Sun, "fa-sun" },
            { IconName.SwimmingPool, "fa-swimming-pool" },
            { IconName.Sync, "fa-sync" },
            { IconName.SyncAlt, "fa-sync-alt" },
            { IconName.Tablet, "fa-tablet" },
            { IconName.Tag, "fa-tag" },
            { IconName.Taxi, "fa-taxi" },
            { IconName.TextHeight, "fa-text-height" },
            { IconName.ThumbsDown, "fa-thumbs-down" },
            { IconName.ThumbsUp, "fa-thumbs-up" },
            { IconName.TicketAlt, "fa-ticket-alt" },
            { IconName.Times, "fa-times" },
            { IconName.TimesCircle, "fa-times-circle" },
            { IconName.Tint, "fa-tint" },
            { IconName.TintSlash, "fa-tint-slash" },
            { IconName.TrafficLight, "fa-traffic-light" },
            { IconName.Train, "fa-train" },
            { IconName.Tram, "fa-tram" },
            { IconName.Tree, "fa-tree" },
            { IconName.Truck, "fa-truck" },
            { IconName.Tv, "fa-tv" },
            { IconName.UmbrellaBeach, "fa-umbrella-beach" },
            { IconName.Underline, "fa-underline" },
            { IconName.Undo, "fa-undo" },
            { IconName.Unlock, "fa-unlock" },
            { IconName.User, "fa-user" },
            { IconName.UserCheck, "fa-user-check" },
            { IconName.UserCircle, "fa-user-circle" },
            { IconName.UserFriends, "fa-user-friends" },
            { IconName.UserPlus, "fa-user-plus" },
            { IconName.Users, "fa-users" },
            { IconName.UserTie, "fa-user-tie" },
            { IconName.Utensils, "fa-utensils" },
            { IconName.Video, "fa-video" },
            { IconName.VideoSlash, "fa-video-slash" },
            { IconName.Voicemail, "fa-voicemail" },
            { IconName.VolumeDown, "fa-volume-down" },
            { IconName.VolumeMute, "fa-volume-mute" },
            { IconName.VolumeOff, "fa-volume-off" },
            { IconName.VolumeUp, "fa-volume-up" },
            { IconName.Walking, "fa-walking" },
            { IconName.Wallet, "fa-wallet" },
            { IconName.Wheelchair, "fa-wheelchair" },
            { IconName.Wifi, "fa-wifi" },
            { IconName.WineBottle, "fa-wine-bottle" },
            { IconName.Wrench, "fa-wrench" },
        };

        private static Dictionary<IconStyle, string> styles = new Dictionary<IconStyle, string>
        {
            { IconStyle.Solid, "fas" },
            { IconStyle.Regular, "far" },
            { IconStyle.Light, "fal" },
            { IconStyle.DuoTone, "fad" },
        };

        #endregion

        #region Constructors

        #endregion

        #region Methods

        public override string GetIconName( IconName iconName )
        {
            names.TryGetValue( iconName, out var name );

            return name;
        }

        public override void SetIconName( IconName name, string newName )
        {
            names[name] = newName;
        }

        public override string GetStyleName( IconStyle iconStyle )
        {
            if ( styles.TryGetValue( iconStyle, out var style ) )
                return style;

            return null;
        }

        protected override bool ContainsStyleName( string iconName )
        {
            return iconName.Split( ' ' ).Any( x => styles.Values.Contains( x ) || new string[] { "fab" }.Contains( x ) );
        }

        #endregion

        #region Properties

        public override bool IconNameAsContent => false;

        #endregion
    }
}
