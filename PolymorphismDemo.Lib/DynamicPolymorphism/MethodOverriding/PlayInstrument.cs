namespace PolymorphismDemo.Lib.DynamicPolymorphism.MethodOverriding
{
    public class PlayInstrument
    {
        public string StartPlaying(Instrument instrument)
        {
            return instrument.Play();
        }
    }
}
