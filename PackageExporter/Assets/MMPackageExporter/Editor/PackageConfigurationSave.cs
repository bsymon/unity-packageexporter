﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MM.PackageExporter
{
    /// <summary>
    /// Describes a Package Configuration to be saved as a new asset.
    /// </summary>
    public class PackageConfigurationSave : ScriptableObject
    {
        public List<string> asset_path_list;

        public void SavePackageConfiguration(AssetInfoHolder asset_holder)
        {
            if ( asset_holder != null )
            {
                List<AssetInfo> asset_list = asset_holder.GetAssetInfos();
                if ( asset_list != null )
                {
                    asset_path_list = new List<string>();
                    foreach(AssetInfo asset in asset_list)
                    {
                        if ( asset.is_directory == false && asset.is_selected == true )
                        {
                            asset_path_list.Add(asset.path);
                        }
                    }
                }
            }
        }
    }
}