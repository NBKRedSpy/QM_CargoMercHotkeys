using QM_CargoMercHotkeys;
using QM_CargoMercHotkeys.Mcm;
using ModConfigMenu;
using ModConfigMenu.Objects;
using System.Collections.Generic;

namespace QM_CargoMercHotkeys.Mcm
{
    internal class McmConfiguration : McmConfigurationBase<ModConfig>
    {

        public McmConfiguration(ModConfig config, Logger logger) : base (config, logger) { }

        public override void Configure()
        {
            ModConfigMenuAPI.RegisterModConfig("Cargo and Merc Keys", new List<ConfigValue>()
            {
                CreateReadOnly(nameof(ModConfig.MercenariesKey)),
                CreateReadOnly(nameof(ModConfig.CargoKey))
            }, OnSave);
        }
    }
}
