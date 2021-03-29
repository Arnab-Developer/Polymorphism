using PolymorphismDemo.Lib.DynamicPolymorphism.MethodOverriding;
using Xunit;

namespace PolymorphismDemo.Test.DynamicPolymorphismTests
{
    public class MethodOverridingTest
    {
        [Fact]
        public void Can_PlayingGuiter_ReturnProperMessage()
        {
            PlayInstrument playInstrument = new();
            Instrument instrument = new Guiter();
            string message = playInstrument.StartPlaying(instrument);
            Assert.Equal("Guiter like sound", message);
        }

        [Fact]
        public void Can_PlayingPiano_ReturnProperMessage()
        {
            PlayInstrument playInstrument = new();
            Instrument instrument = new Piano();
            string message = playInstrument.StartPlaying(instrument);
            Assert.Equal("Piano like sound", message);
        }
    }
}
