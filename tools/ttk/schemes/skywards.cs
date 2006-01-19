\name SkyWards
\def black   #000000
\def unwhite #ebebeb
\def gray    #a0a0a0
\def dkgray  #505050

  header: bg => unwhite,
	  fg => black,
	  line => #9fa2a7 -1,
	  accent => gray
	  shadow => dkgray,
	  shine => gray,
	  gradient.top => #e0e0e0,
	  gradient.middle => #e0e0e0,
	  gradient.bottom => #d6d6d6,
	  gradient.bar => #f2f2f2 +1

   music: bar.bg => #f7f7f7,
	  bar => <vert #c0c2c8 to #b4b7bd to #aaacb2 with #80848e @:3,0,1,0> +1

 battery: border => #86898f,
	  bg => #f7f7f7,
	  bg.low => <vert #fdcece to #ec6868>,
	  bg.charging => <vert #ceedfc to #52b9ef>,
	  fill.normal => <#c0c2c8 to #b4b7bd to #aaacb2 with #80848e @:3,0,1,0> +1
	  fill.low => dkgray +1,
	  fill.charge => <vert #69777f to black> +1

    lock: border => black,
	  fill => black

 loadavg: bg => gray,
	  fg => dkgray,
	  spike => unwhite

  window: bg => unwhite,
	  fg => black,
	  border => gray -3

  dialog: bg => unwhite,
	  fg => black,
	  line => #9fa2a7,
	  title.fg => black,	
	  button.bg => <#e0e0e0, #e0e0e0, #d6d6d6 with #f2f2f2 @:1,0,10,0>,
	  button.fg => black,
	  button.border => #9fa2a7,
	  button.sel.bg => <#c0c0c0, #c0c0c0, #b6b6b6 with #d2d2d2 @:1,0,10,0>,
	  button.sel.fg => black,
	  button.sel.border => #86898f,
	  button.sel.inner => #86898f

   error: bg => unwhite,
	  fg => black,
	  line => #9fa2a7,
	  title.fg => black,
	  button.bg => <#e0e0e0, #e0e0e0, #d6d6d6 with #f2f2f2 @:1,0,10,0>,
	  button.fg => black,
	  button.border => #9fa2a7,
	  button.sel.bg => <#c0c0c0, #c0c0c0, #b6b6b6 with #d2d2d2 @:1,0,10,0>,
	  button.sel.fg => black,
	  button.sel.border => #86898f,
	  button.sel.inner => #86898f

  scroll: box => #86898f -1,
	  bg => #f7f7f7,
	  bar => <horiz #cdcfd3 to #b4b7bd to #aaacb2 with #80848e @:0,1,0,4> +1

   input: bg => unwhite,
	  fg => black,
	  selbg => dkgray,
	  selfg => unwhite,
	  border => gray,
	  cursor => dkgray

    menu: bg => unwhite,
	  fg => black,
	  choice => black,
	  icon => black,
	  selbg => <vert #9599a3 to #9599a3 to #aaacb2 with #a0a2a8 @:1,0,9,0>,
	  selfg => black,
	  selchoice => unwhite,
	  icon0 => #aaacb2,
	  icon1 => #bbb,
	  icon2 => #cbcbcb,
	  icon3 => unwhite

  slider: border => #86898f -2,
	  bg => unwhite,
	  full => <vert #e0e1e4 to #b4b7bd to #aaacb2 with #80848e @:6,0,1,0>

textarea: bg => unwhite,
	  fg => black

     box: default.bg => <#e0e0e0, #e0e0e0, #d6d6d6 with #f2f2f2 @:1,0,10,0>,
	  default.fg => black,
	  default.border => #9fa2a7,
	  selected.bg => <#c0c0c0, #c0c0c0, #b6b6b6 with #d2d2d2 @:1,0,10,0>,
	  selected.fg => black,
	  selected.border => #86898f,
	  special.bg =>  <#d0d0d0, #d0d0d0, #c6c6c6 with #e2e2e2 @:1,0,10,0>,
	  special.fg => black,
	  special.border => #333

  button: default.bg => <#e0e0e0, #e0e0e0, #d6d6d6 with #f2f2f2 @:1,0,10,0>,
	  default.fg => black,
	  default.border => #9fa2a7,
	  selected.bg => <#c0c0c0, #c0c0c0, #b6b6b6 with #d2d2d2 @:1,0,10,0>,
	  selected.fg => black,
	  selected.border => #86898f
