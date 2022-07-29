using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace JnSpoofer.Properties
{
	// Token: 0x02000018 RID: 24
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[DebuggerNonUserCode]
	internal class Resources
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x00002168 File Offset: 0x00000368
		internal Resources()
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x000093D4 File Offset: 0x000075D4
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					ResourceManager resourceManager = new ResourceManager("JnSpoofer.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00009414 File Offset: 0x00007614
		// (set) Token: 0x060000DA RID: 218 RVA: 0x000024F4 File Offset: 0x000006F4
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00009428 File Offset: 0x00007628
		internal static Bitmap icons8_discord_new_100
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("icons8_discord_new_100", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00009454 File Offset: 0x00007654
		internal static Bitmap icons8_spinner
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("icons8_spinner", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00009480 File Offset: 0x00007680
		internal static Bitmap loading_2
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("loading_2", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x0400009A RID: 154
		private static ResourceManager resourceMan;

		// Token: 0x0400009B RID: 155
		private static CultureInfo resourceCulture;
	}
}
