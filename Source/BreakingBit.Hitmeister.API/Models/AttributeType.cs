using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The type of value that the <see cref="Attribute"/> accepts.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Most <see cref="Attribute"/>s accept free text for their values, but some types 
    /// of attributes have formatting restrictions.
    /// </para>
    /// <para>
    /// Any attribute type that starts with "Si_" is a numeric value in the International System of Units. 
    /// When you submit a value for these attributes, it must contain a number and a unit suffix 
    /// (e.g. Si_Meter could have any of the following values: 1m; 2,5m; 200.432,43m; 250mm; 7km).
    /// </para>
    /// </remarks>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AttributeType
    {

        /// <summary>
        /// A boolean value. Accepts the following values: true, false, 0, 1, T, F, yes, no, Y, N, ja, nein.
        /// </summary>
        [EnumMember(Value = "Bool")]
        Bool,

        /// <summary>
        /// A valid <see cref="Models.Ean"/>.
        /// </summary>
        [EnumMember(Value = "Ean")]
        Ean,

        /// <summary>
        /// Free text feature bullet.
        /// </summary>
        [EnumMember(Value = "Feature")]
        Feature,

        /// <summary>
        /// A decimal number. The decimal separator should be a comma (,) and, if specified,
        /// the thousands separator should be a period (.).
        /// </summary>
        [EnumMember(Value = "Float")]
        Float,

        /// <summary>
        /// A whole number without any decimal values.
        /// </summary>
        [EnumMember(Value = "Int")]
        Int,

        /// <summary>
        /// A text string with a maximum length of 512 characters.
        /// </summary>
        [EnumMember(Value = "ShortText")]
        ShortText,

        /// <summary>
        /// A text string with a maximum length of 1024 characters.
        /// </summary>
        [EnumMember(Value = "SmallText")]
        SmallText,

        /// <summary>
        /// A text string with a maximum length of 65,535 characters.
        /// </summary>
        [EnumMember(Value = "Text")]
        Text,

        /// <summary>
        /// A text string with a maximum length of 256 characters.
        /// </summary>
        [EnumMember(Value = "TinyText")]
        TinyText,

        /// <summary>
        /// Free text.
        /// </summary>
        [EnumMember(Value = "Track")]
        Track,

        /// <summary>
        /// A string corresponding to an URL, embedded as a link.
        /// </summary>
        [EnumMember(Value = "Url")]
        Url,

        /// <summary>
        /// A date in the format d.m.Y, e.g. 23.10.2014.
        /// </summary>
        [EnumMember(Value = "Date")]
        Date,

        /// <summary>
        /// Enum Item for "Item"
        /// </summary>
        [EnumMember(Value = "Item")]
        Item,

        /// <summary>
        /// A publicly-accessible URL from which an image file can be downloaded. 
        /// Acceptable image file types are jpg, png, and gif.
        /// </summary>
        [EnumMember(Value = "Picture")]
        Picture,

        /// <summary>
        /// Quantity: Euro; Unit: EUR/100
        /// </summary>
        [EnumMember(Value = "Si_Eurocent")]
        Eurocent,

        /// <summary>
        /// Quantity: Electric Current; Unit = A
        /// </summary>
        [EnumMember(Value = "Si_Ampere")]
        Ampere,

        /// <summary>
        /// Quantity: Electric Charge; Unit = Ah
        /// </summary>
        [EnumMember(Value = "Si_AmpereHour")]
        AmpereHour,

        /// <summary>
        /// Quantity: Pressure; Unit = 100000Pa
        /// </summary>
        [EnumMember(Value = "Si_Bar")]
        Bar,

        /// <summary>
        /// The ratio of power and amplitude, mostly known as (deci)bel
        /// </summary>
        [EnumMember(Value = "Si_Bel")]
        Bel,

        /// <summary>
        /// Quantity: Computer Memory; Unit: 1B=8bit
        /// </summary>
        [EnumMember(Value = "Si_Byte")]
        Byte,

        /// <summary>
        /// Quantity: Volume; Unit: m^3
        /// </summary>
        [EnumMember(Value = "Si_CubicMeter")]
        CubicMeter,

        /// <summary>
        /// Quantity: Flow Rate; Unit: m^3/h
        /// </summary>
        [EnumMember(Value = "Si_CubicMeterPerHour")]
        CubicMeterPerHour,

        /// <summary>
        /// Quantity: Temperature; Unit: 273.15K
        /// </summary>
        [EnumMember(Value = "Si_DegreeCelsius")]
        DegreeCelsius,

        /// <summary>
        /// Quantity: Frequency; Unit: hz=s^-1
        /// </summary>
        [EnumMember(Value = "Si_Herz")]
        Herz,

        /// <summary>
        /// Quantity: Power; Unit: 735,499W
        /// </summary>
        [EnumMember(Value = "Si_HorsePower")]
        HorsePower,

        /// <summary>
        /// Quantity: Length; Unit: 0,0254m
        /// </summary>
        [EnumMember(Value = "Si_Inch")]
        Inch,

        /// <summary>
        /// Quantity: Temperature; Unit: K
        /// </summary>
        [EnumMember(Value = "Si_Kelvin")]
        Kelvin,

        /// <summary>
        /// Quantity: Mass; Unit: kg
        /// </summary>
        [EnumMember(Value = "Si_Kilogram")]
        Kilogram,

        /// <summary>
        /// Quantity: Area Density; Unit: m^-2/kg
        /// </summary>
        [EnumMember(Value = "Si_KilogramPerSquareMeter")]
        KilogramPerSquareMeter,

        /// <summary>
        /// Quantity: Volume; Unit: 0,001m^3
        /// </summary>
        [EnumMember(Value = "Si_Litre")]
        Litre,

        /// <summary>
        /// Enum SiLitrePerHour for "Si_LitrePerHour"
        /// </summary>
        [EnumMember(Value = "Si_LitrePerHour")]
        LitrePerHour,

        /// <summary>
        /// Quantity: Lumen; Unit: cd
        /// </summary>
        [EnumMember(Value = "Si_Lumen")]
        Lumen,

        /// <summary>
        /// Quantity: Length; Unit: m
        /// </summary>
        [EnumMember(Value = "Si_Meter")]
        Meter,

        /// <summary>
        /// Quantity: Mass; Unit: 0,0283495231kg
        /// </summary>
        [EnumMember(Value = "Si_Ounce")]
        Ounce,

        /// <summary>
        /// Quantity: Percent; Unit: 1/100
        /// </summary>
        [EnumMember(Value = "Si_Percent")]
        Percent,

        /// <summary>
        /// Quantity: Pixel; Unit: px
        /// </summary>
        [EnumMember(Value = "Si_Pixel")]
        Pixel,

        /// <summary>
        /// Quantity: RPM; Unit: (60s)^-1
        /// </summary>
        [EnumMember(Value = "Si_RoundsPerMinute")]
        RoundsPerMinute,

        /// <summary>
        /// Quantity: Second; Unit: s
        /// </summary>
        [EnumMember(Value = "Si_Second")]
        Second,

        /// <summary>
        /// Quantity: Area; Unit: m^2
        /// </summary>
        [EnumMember(Value = "Si_SquareMeter")]
        SquareMeter,

        /// <summary>
        /// Quantity: Voltage; Unit: W/A
        /// </summary>
        [EnumMember(Value = "Si_Volt")]
        Volt,

        /// <summary>
        /// Quantity: Volume; Unit: m^3/100
        /// </summary>
        [EnumMember(Value = "Si_VolumePercent")]
        VolumePercent,

        /// <summary>
        /// Quantity: Power; Unit: W
        /// </summary>
        [EnumMember(Value = "Si_Watt")]
        Watt
    }
}
