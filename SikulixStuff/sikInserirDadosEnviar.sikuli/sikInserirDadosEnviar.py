import random
randCode = ''.join(random.choice(['a', 'b']) for _ in range(2)) + ''.join(str(random.randint(0, 9)) for _ in range(6)) 
randSecs = str(random.randint(10, 50))
click(Pattern("DesktopApp-3.png").targetOffset(-47,-17))
type(randCode + Key.TAB)
type(randSecs)
click(Pattern("DesktopApp-4.png").targetOffset(132,36))
click(Pattern("DropdownMenu.png").targetOffset(-80,-23))
click(Pattern("DesktopApp-5.png").targetOffset(-115,68))


