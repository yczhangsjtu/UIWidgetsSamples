using System.Collections.Generic;
using Unity.UIWidgets.foundation;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UnityEngine;
using Material = Unity.UIWidgets.material.Material;

namespace UIWidgetsSample
{
    public class TextShadow : UIWidgetsSamplePanel
    {
        protected override Widget createWidget()
        {
            return new MaterialApp(
                showPerformanceOverlay: false,
                home: new Material(
                    child: new TestTextShadowWidget()),
                builder: (_, child) =>
                {
                    return new Builder(builder:
                        context =>
                        {
                            return new MediaQuery(
                                data: MediaQuery.of(context).copyWith(
                                    textScaleFactor: 1.0f
                                ),
                                child: child);
                        });
                });
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            FontManager.instance.addFont(Resources.Load<Font>(path: "fonts/MaterialIcons-Regular"), "Material Icons");
        }
    }

    internal class TestTextShadowWidget : StatefulWidget
    {
        public TestTextShadowWidget(Key key = null) : base(key)
        {
        }

        public override State createState()
        {
            return new TestTextShadowWidgetState();
        }
    }

    internal class TestTextShadowWidgetState : State<TestTextShadowWidget>
    {
        public override Widget build(BuildContext context)
        {
            return new Container(
                child: new ListView(
                    children: new List<Widget>
                    {
                        new Text("Hello World", style: new TextStyle(
                            fontSize: 18,
                            shadows: new List<BoxShadow> {
                                new BoxShadow(Colors.red, blurRadius: 1)
                            })),
                        new Text("Hello World", style: new TextStyle(
                            fontSize: 18,
                            shadows: new List<BoxShadow> {
                                new BoxShadow(Colors.red, blurRadius: 2)
                            })),
                        new Text("Hello World", style: new TextStyle(
                            fontSize: 18,
                            shadows: new List<BoxShadow> {
                                new BoxShadow(Colors.red, blurRadius: 3)
                            })),
                        new Text("Hello World", style: new TextStyle(
                            fontSize: 18,
                            shadows: new List<BoxShadow> {
                                new BoxShadow(Colors.green, blurRadius: 3)
                            })),
                        new Text("Hello World", style: new TextStyle(
                            fontSize: 18,
                            shadows: new List<BoxShadow> {
                                new BoxShadow(Colors.blue, blurRadius: 3)
                            })),
                        new Text("Hello World", style: new TextStyle(
                            fontSize: 18,
                            shadows: new List<BoxShadow> {
                                new BoxShadow(Colors.blue, offset: new Offset(1, 0), blurRadius: 3)
                            })),
                        new Text("Hello World", style: new TextStyle(
                            fontSize: 18,
                            shadows: new List<BoxShadow> {
                                new BoxShadow(Colors.blue, offset: new Offset(2, 0), blurRadius: 3)
                            })),
                        new Text("Hello World", style: new TextStyle(
                            fontSize: 18,
                            shadows: new List<BoxShadow> {
                                new BoxShadow(Colors.blue, offset: new Offset(3, 1), blurRadius: 3)
                            })),
                        new Text("Hello World", style: new TextStyle(
                            fontSize: 18,
                            shadows: new List<BoxShadow> {
                                new BoxShadow(Colors.blue, offset: new Offset(3, 2), blurRadius: 3)
                            })),
                        new Text("Hello World \ud83d\ude04\u00ae\u00a9\ufe0f\ud83c\udde8\ud83c\udded\ud83c\uddea", style: new TextStyle(
                            fontSize: 18,
                            shadows: new List<BoxShadow> {
                                new BoxShadow(Colors.blue, offset: new Offset(3, 3), blurRadius: 3)
                            })),
                        new Text("Hello World \ud83d\ude04\u00ae\u00a9\ufe0f\ud83c\udde8\ud83c\udded\ud83c\uddea", style: new TextStyle(
                            fontSize: 18,
                            shadows: new List<BoxShadow> {
                                new BoxShadow(Colors.blue, offset: new Offset(2, 2), blurRadius: 2)
                            })),
                        new Text("Hello World \ud83d\ude04\u00ae\u00a9\ufe0f\ud83c\udde8\ud83c\udded\ud83c\uddea", style: new TextStyle(
                            fontSize: 18,
                            shadows: new List<BoxShadow> {
                                new BoxShadow(Colors.blue, offset: new Offset(1, 1), blurRadius: 1)
                            })),
                        new Text("Hello World \ud83d\ude04\u00ae\u00a9\ufe0f\ud83c\udde8\ud83c\udded\ud83c\uddea", style: new TextStyle(
                            fontSize: 20,
                            shadows: new List<BoxShadow> {
                                new BoxShadow(Colors.blue, offset: new Offset(1, 1), blurRadius: 1)
                            })),
                        new Text("Hello World \ud83d\ude04\u00ae\u00a9\ufe0f\ud83c\udde8\ud83c\udded\ud83c\uddea", style: new TextStyle(
                            fontSize: 24,
                            shadows: new List<BoxShadow> {
                                new BoxShadow(Colors.blue, offset: new Offset(1, 1), blurRadius: 1)
                            })),
                        new Text("Hello World \ud83d\ude04\u00ae\u00a9\ufe0f\ud83c\udde8\ud83c\udded\ud83c\uddea", style: new TextStyle(
                            fontSize: 24,
                            shadows: new List<BoxShadow> {
                                new BoxShadow(Colors.red, offset: new Offset(1, 1), blurRadius: 1)
                            })),
                        new Text("Hello World \ud83d\ude04\u00ae\u00a9\ufe0f\ud83c\udde8\ud83c\udded\ud83c\uddea", style: new TextStyle(
                            fontSize: 24,
                            shadows: new List<BoxShadow> {
                                new BoxShadow(Colors.yellow, offset: new Offset(1, 1), blurRadius: 1)
                            })),
                        new Text("Hello World \ud83d\ude04\u00ae\u00a9\ufe0f\ud83c\udde8\ud83c\udded\ud83c\uddea", style: new TextStyle(
                            fontSize: 24,
                            shadows: new List<BoxShadow> {
                                new BoxShadow(Colors.green, offset: new Offset(1, 1), blurRadius: 1)
                            })),
                    }));
        }
    }
}
