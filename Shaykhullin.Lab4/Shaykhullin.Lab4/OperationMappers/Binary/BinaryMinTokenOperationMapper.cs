
using Shaykhullin.Lexemes;
using Shaykhullin.Operations;

namespace Shaykhullin.OperationMappers
{
  public class BinaryMinLexemeOperationMapper
  : BinaryLexemeOperationMapper<MinLexeme, BinaryMinOperation>
  {
  }

  public class BinaryMaxLexemeOperationMapper
  : BinaryLexemeOperationMapper<MaxLexeme, BinaryMaxOperation>
  {
  }

  public class RoundLexemeOperationMapper
  : UnaryLexemeOperationMapper<RoundLexeme, UnaryRoundOperation>
  {
  }

  public class TruncLexemeOperationMapper
  : UnaryLexemeOperationMapper<TruncLexeme, UnaryTruncOperation>
  {
  }

  public class FloorLexemeOperationMapper
  : UnaryLexemeOperationMapper<FloorLexeme, UnaryFloorOperation>
  {
  }

  public class CeilLexemeOperationMapper
  : UnaryLexemeOperationMapper<CeilLexeme, UnaryCeilOperation>
  {
  }

  public class SinLexemeOperationMapper
  : UnaryLexemeOperationMapper<SinLexeme, UnarySinOperation>
  {
  }

  public class CosLexemeOperationMapper
  : UnaryLexemeOperationMapper<CosLexeme, UnaryCosOperation>
  {
  }

  public class TanLexemeOperationMapper
  : UnaryLexemeOperationMapper<TanLexeme, UnaryTanOperation>
  {
  }

  public class CotanLexemeOperationMapper
  : UnaryLexemeOperationMapper<CotanLexeme, UnaryCotanOperation>
  {
  }

  public class ArcsinLexemeOperationMapper
  : UnaryLexemeOperationMapper<ArcsinLexeme, UnaryArcsinOperation>
  {
  }

  public class ArccosLexemeOperationMapper
  : UnaryLexemeOperationMapper<ArccosLexeme, UnaryArccosOperation>
  {
  }

  public class ArctanLexemeOperationMapper
  : UnaryLexemeOperationMapper<ArctanLexeme, UnaryArctanOperation>
  {
  }

  public class LnLexemeOperationMapper
  : UnaryLexemeOperationMapper<LnLexeme, UnaryLnOperation>
  {
  }

  public class AbsLexemeOperationMapper
  : UnaryLexemeOperationMapper<AbsLexeme, UnaryAbsOperation>
  {
  }

  public class SignLexemeOperationMapper
  : UnaryLexemeOperationMapper<SignLexeme, UnarySignOperation>
  {
  }
}
