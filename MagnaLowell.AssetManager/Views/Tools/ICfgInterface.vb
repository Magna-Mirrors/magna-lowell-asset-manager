Imports MagnaLowell.AssetManager.Models

Public Interface ICfgInterface
    Function WriteConfig(c As CfgSettings) As Boolean
    Function ReadCfg() As CfgSettings
End Interface