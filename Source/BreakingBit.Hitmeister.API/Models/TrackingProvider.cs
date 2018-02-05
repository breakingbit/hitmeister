namespace BreakingBit.Hitmeister.API.Models
{
    public enum TrackingProvider
    {
        ///<summary>
        /// No listed parcel service applies.
        ///</summary>
        Other,

        ///<summary>
        /// No list parcel service applies, but the chosen parcel service is a hauler.
        ///</summary>
        OtherHauler,

        ///<summary>
        /// Parcel service from Bursped.
        ///</summary>
        Bursped,

        ///<summary>
        /// Parcel service from Cargoline.
        ///</summary>
        Cargoline,

        ///<summary>
        /// Parcel service from Computeruniverse.
        ///</summary>
        Computeruniverse,

        ///<summary>
        /// Parcel service from DHL.
        ///</summary>
        DHL,

        ///<summary>
        /// Parcel service from DHL 2 MH.
        ///</summary>
        DHL2MH,

        ///<summary>
        /// Parcel service from DHL Express.
        ///</summary>
        DHLExpress,

        ///<summary>
        /// Parcel service from DHL Freight.
        ///</summary>
        DHLFreight,

        ///<summary>
        /// Parcel service from dtl.
        ///</summary>
        Dtl,

        ///<summary>
        /// Parcel service from DPD.
        ///</summary>
        DPD,

        ///<summary>
        /// Parcel service from Deutsche Post.
        ///</summary>
        DeutschePost,

        ///<summary>
        /// Parcel service from Dachser.
        ///</summary>
        Dachser,

        ///<summary>
        /// Parcel service from Marktanlieferung.
        ///</summary>
        Marktanlieferung,

        ///<summary>
        /// Parcel service from Emons.
        ///</summary>
        Emons,

        ///<summary>
        /// Parcel service from Fedex.
        ///</summary>
        Fedex,

        ///<summary>
        /// Parcel service from GLS.
        ///</summary>
        GLS,

        ///<summary>
        /// Parcel service from GEL.
        ///</summary>
        GEL,

        ///<summary>
        /// Parcel service from Hermes.
        ///</summary>
        Hermes,

        ///<summary>
        /// Parcel service from Hermes 2 MH.
        ///</summary>
        Hermes2MH,

        ///<summary>
        /// Parcel service from Hellmann.
        ///</summary>
        Hellmann,

        ///<summary>
        /// Parcel service from IDS Logistik.
        ///</summary>
        IDSLogistik,

        ///<summary>
        /// Parcel service from Iloxx.
        ///</summary>
        Iloxx,

        ///<summary>
        /// Parcel service from Kuehne & Nagel.
        ///</summary>
        KuehneNagel,

        ///<summary>
        /// Parcel service from Post Italiane.
        ///</summary>
        PostItaliane,

        ///<summary>
        /// Parcel service from Rhenus.
        ///</summary>
        Rhenus,

        ///<summary>
        /// Parcel service from Schenker.
        ///</summary>
        Schenker,

        ///<summary>
        /// Parcel service from Spedition Guettler.
        ///</summary>
        SpeditionGuettler,

        ///<summary>
        /// Parcel service from TNT.
        ///</summary>
        TNT,

        ///<summary>
        /// Parcel service from Trans FM.
        ///</summary>
        TransFM,

        ///<summary>
        /// Parcel service from trans-o-flex.
        ///</summary>
        TransOFlex,

        ///<summary>
        /// Parcel service from UPS.
        ///</summary>
        UPS,

        ///<summary>
        /// The parcel service is randomly chosen.
        ///</summary>
        Zufall
    }
}
