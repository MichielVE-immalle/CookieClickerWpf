# CookieClicker

## waarom ?

> u denkt zeker:"waarom een cookie clicker maken tijdens de les",
> wel waarom niet. Het is een leuk spelletje om wat meer bij te leren van CSharp

## opdeling code 

### vorm v/h koekje
```
    private void Coockie_MouseEnter(object sender, MouseEventArgs e)
        {
            Coockie.Fill = new SolidColorBrush(Colors.SaddleBrown);
            Coockie.StrokeThickness = 4;
            Coockie.Stroke = new SolidColorBrush(Colors.Black);
        }

        private void Coockie_MouseLeave(object sender, MouseEventArgs e)
        {
            Coockie.Fill = new SolidColorBrush(Colors.Gray);
            Coockie.StrokeThickness = 2;
            Coockie.Stroke = new SolidColorBrush(Colors.Black);
        }

```

### code voor click event
```
          private void Coockie_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (getal < 500)
            {
                getal = getal + 1;
                teller.Text = String.Format("{0}", getal);
            }

            if (getal >= 500)
            {
                getal = getal + 2;
                teller.Text = String.Format("{0}", getal);
            }
        }
        
```
