using LibAtem.Commands;
using LibAtem.Commands.MixEffects.Key;
using LibAtem.Common;
using LibAtem.Serialization;

namespace LibAtem.MacroOperations.MixEffects.Key.DVE
{
    [MacroOperation(MacroOperationType.DVEKeyBorderOpacity, 8)]
    public class DVEKeyBorderOpacityMacroOp : MixEffectKeyMacroOpBase
    {
        [Serialize(6), UInt8Range(0, 100)]
        [MacroField("Opacity")]
        public uint Opacity { get; set; }

        public override ICommand ToCommand(ProtocolVersion version)
        {
            return new MixEffectKeyDVESetCommand()
            {
                Mask = MixEffectKeyDVESetCommand.MaskFlags.BorderOpacity,
                MixEffectIndex = Index,
                KeyerIndex = KeyIndex,
                BorderOpacity = Opacity,
            };
        }
    }
}