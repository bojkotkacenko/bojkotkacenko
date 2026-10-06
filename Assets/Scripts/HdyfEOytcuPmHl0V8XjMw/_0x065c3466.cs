/// Named sorting orders for every world sprite in the garden.
/// The whole band lives in -19..-1: the scene backgrounds sit on a canvas at -30 and
/// every panel / pop canvas starts at 0 and 10, so nothing here can ever draw over a
/// result card (rules C.0 and C.21). Never write a bare number at a call site.
public static class _0x065c3466
{
    public const int TagOrder = -12;
    public const int SparkOrder = -3;
    public const int BackdropOrder = -19;
    public const int BasketOrder = -8;
    public const int TrayOrder = -16;
    public const int DecorOrder = -1;
    public const int TagIconOrder = -10;
    public const int QueueOrder = -4;
    public const int FruitOrder = -6;
}