using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The current processing status of a file import
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ImportFileStatus
    {
        /// <summary>
        /// The import has been aborted
        /// </summary>
        [EnumMember(Value = "ABORTED")]
        Aborted,

        /// <summary>
        /// The import has been checked
        /// </summary>
        [EnumMember(Value = "CHECKED")]
        Checked,

        /// <summary>
        /// The import file is currently being checked
        /// </summary>
        [EnumMember(Value = "CHECKING")]
        Checking,

        /// <summary>
        /// Import file checking failed
        /// </summary>
        [EnumMember(Value = "CHECKING_FAILED")]
        CheckingFailed,

        /// <summary>
        /// The import has finished
        /// </summary>
        [EnumMember(Value = "DONE")]
        Done,

        /// <summary>
        /// The file has just been downloaded
        /// </summary>
        [EnumMember(Value = "DOWNLOADED")]
        Downloaded,

        /// <summary>
        /// The server is downloading the file
        /// </summary>
        [EnumMember(Value = "DOWNLOADING")]
        Downloading,

        /// <summary>
        /// The import file download failed
        /// </summary>
        [EnumMember(Value = "DOWNLOADING_FAILED")]
        DownloadingFailed,

        /// <summary>
        /// The file has been completely imported
        /// </summary>
        [EnumMember(Value = "IMPORTED")]
        Imported,

        /// <summary>
        /// The file is currently being imported
        /// </summary>
        [EnumMember(Value = "IMPORTING")]
        Importing,

        /// <summary>
        /// The file import processing stage failed
        /// </summary>
        [EnumMember(Value = "IMPORTING_FAILED")]
        ImportingFailed,

        /// <summary>
        /// The import has been stopped during the import step
        /// </summary>
        [EnumMember(Value = "IMPORTING_STOPPED")]
        ImportingStopped,

        /// <summary>
        /// The import task is new and has not begin to process yet
        /// </summary>
        [EnumMember(Value = "NEW")]
        New,

        /// <summary>
        /// The import file has been prepared for import
        /// </summary>
        [EnumMember(Value = "PREPARED")]
        Prepared,

        /// <summary>
        /// The file is currently being prepared for import
        /// </summary>
        [EnumMember(Value = "PREPARING")]
        Preparing,

        /// <summary>
        /// The file preparation failed
        /// </summary>
        [EnumMember(Value = "PREPARING_FAILED")]
        PreparingFailed,

        /// <summary>
        /// The import just finished preprocessing
        /// </summary>
        [EnumMember(Value = "PREPROCESSED")]
        Preprocessed,

        /// <summary>
        /// The import is currently preprocessing
        /// </summary>
        [EnumMember(Value = "PREPROCESSING")]
        Preprocessing,

        /// <summary>
        /// The preprocessing stage failed
        /// </summary>
        [EnumMember(Value = "PREPROCESSING_FAILED")]
        PreprocessingFailed,

        /// <summary>
        /// The importer is currently waiting to start processing
        /// </summary>
        [EnumMember(Value = "WAITING")]
        Waiting
    }
}
