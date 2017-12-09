
using Shaykhullin.Tokens;
using Shaykhullin.Operations;

namespace Shaykhullin.OperationMappers
{
  public class BinaryMinTokenOperationMapper
  : BinaryOperationMapper<MinToken, BinaryMinOperation>
  {
  }

  public class BinaryMaxTokenOperationMapper
  : BinaryOperationMapper<MaxToken, BinaryMaxOperation>
  {
  }

  public class RoundTokenOperationMapper
  : UnaryOperationMapper<RoundToken, UnaryRoundOperation>
  {
  }

  public class TruncTokenOperationMapper
  : UnaryOperationMapper<TruncToken, UnaryTruncOperation>
  {
  }

  public class FloorTokenOperationMapper
  : UnaryOperationMapper<FloorToken, UnaryFloorOperation>
  {
  }

  public class CeilTokenOperationMapper
  : UnaryOperationMapper<CeilToken, UnaryCeilOperation>
  {
  }

  public class SinTokenOperationMapper
  : UnaryOperationMapper<SinToken, UnarySinOperation>
  {
  }

  public class CosTokenOperationMapper
  : UnaryOperationMapper<CosToken, UnaryCosOperation>
  {
  }

  public class TanTokenOperationMapper
  : UnaryOperationMapper<TanToken, UnaryTanOperation>
  {
  }

  public class CotanTokenOperationMapper
  : UnaryOperationMapper<CotanToken, UnaryCotanOperation>
  {
  }

  public class ArcsinTokenOperationMapper
  : UnaryOperationMapper<ArcsinToken, UnaryArcsinOperation>
  {
  }

  public class ArccosTokenOperationMapper
  : UnaryOperationMapper<ArccosToken, UnaryArccosOperation>
  {
  }

  public class ArctanTokenOperationMapper
  : UnaryOperationMapper<ArctanToken, UnaryArctanOperation>
  {
  }

  public class LnTokenOperationMapper
  : UnaryOperationMapper<LnToken, UnaryLnOperation>
  {
  }

  public class AbsTokenOperationMapper
  : UnaryOperationMapper<AbsToken, UnaryAbsOperation>
  {
  }

  public class SignTokenOperationMapper
  : UnaryOperationMapper<SignToken, UnarySignOperation>
  {
  }
}
