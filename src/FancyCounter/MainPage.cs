using Microsoft.Maui.Graphics;

namespace FancyCounter;
public class MainPage : View
{
    readonly State<int> Count = 0;

	readonly LinearGradientPaint BgGradient = new LinearGradientPaint(
                        new GradientStop[]{
                            new GradientStop(0, Color.FromHex("#21252F")),
                            new GradientStop(1, Color.FromHex("#303645"))
                        },
                        new Point(0,0),
                        new Point(0,1)
                    );

    [Body]
    View body()
        => new Grid {
			new VStack(){
				new Spacer(),
				new Text(()=> $"Count is {Count}.")
					.Color(Colors.White)
					.FontSize(64)
					.LineBreakMode(LineBreakMode.WordWrap) // currently not working as expected
					.HorizontalTextAlignment(TextAlignment.Center)
					.Margin(left:30,right:30),
				new Button("Increment", ()=> Count.Value++)
					.Frame(height:76)
					.FontSize(32)
					.Color(Colors.White)
					.Background(Colors.OrangeRed)
					.RoundedBorder(20)
					.Margin(left:30,right:30),
				new Spacer()
			}
			.Background(BgGradient)
        };
}