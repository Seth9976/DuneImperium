using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	[StructLayout(2)]
	public struct CharacterInfo
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00003FE8 File Offset: 0x000021E8
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterInfo()
		{
			Il2CppClassPointerStore<CharacterInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextRenderingModule.dll", "UnityEngine", "CharacterInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterInfo>.NativeClassPtr);
			CharacterInfo.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInfo>.NativeClassPtr, "index");
			CharacterInfo.NativeFieldInfoPtr_uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInfo>.NativeClassPtr, "uv");
			CharacterInfo.NativeFieldInfoPtr_vert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInfo>.NativeClassPtr, "vert");
			CharacterInfo.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInfo>.NativeClassPtr, "width");
			CharacterInfo.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInfo>.NativeClassPtr, "size");
			CharacterInfo.NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInfo>.NativeClassPtr, "style");
			CharacterInfo.NativeFieldInfoPtr_flipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInfo>.NativeClassPtr, "flipped");
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000023CE File Offset: 0x000005CE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000040A4 File Offset: 0x000022A4
		// (set) Token: 0x0600006A RID: 106 RVA: 0x000023E0 File Offset: 0x000005E0
		public int advance
		{
			get
			{
				return (int)Math.Round((double)this.width, MidpointRounding.AwayFromZero);
			}
			set
			{
				this.width = (float)value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000040C4 File Offset: 0x000022C4
		// (set) Token: 0x0600006C RID: 108 RVA: 0x000023EB File Offset: 0x000005EB
		public int glyphWidth
		{
			get
			{
				return (int)this.vert.width;
			}
			set
			{
				this.vert.width = (float)value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600006D RID: 109 RVA: 0x000040E4 File Offset: 0x000022E4
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00004104 File Offset: 0x00002304
		public int glyphHeight
		{
			get
			{
				return (int)(-(int)this.vert.height);
			}
			set
			{
				float height = this.vert.height;
				this.vert.height = (float)(-(float)value);
				this.vert.y = this.vert.y + (height - this.vert.height);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00004150 File Offset: 0x00002350
		// (set) Token: 0x06000070 RID: 112 RVA: 0x000023FC File Offset: 0x000005FC
		public int bearing
		{
			get
			{
				return (int)this.vert.x;
			}
			set
			{
				this.vert.x = (float)value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00004170 File Offset: 0x00002370
		// (set) Token: 0x06000072 RID: 114 RVA: 0x0000240D File Offset: 0x0000060D
		public int minY
		{
			get
			{
				return (int)(this.vert.y + this.vert.height);
			}
			set
			{
				this.vert.height = (float)value - this.vert.y;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0000419C File Offset: 0x0000239C
		// (set) Token: 0x06000074 RID: 116 RVA: 0x000041BC File Offset: 0x000023BC
		public int maxY
		{
			get
			{
				return (int)this.vert.y;
			}
			set
			{
				float y = this.vert.y;
				this.vert.y = (float)value;
				this.vert.height = this.vert.height + (y - this.vert.y);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00004204 File Offset: 0x00002404
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00004224 File Offset: 0x00002424
		public int minX
		{
			get
			{
				return (int)this.vert.x;
			}
			set
			{
				float x = this.vert.x;
				this.vert.x = (float)value;
				this.vert.width = this.vert.width + (x - this.vert.x);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0000426C File Offset: 0x0000246C
		// (set) Token: 0x06000078 RID: 120 RVA: 0x0000242A File Offset: 0x0000062A
		public int maxX
		{
			get
			{
				return (int)(this.vert.x + this.vert.width);
			}
			set
			{
				this.vert.width = (float)value - this.vert.x;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00004298 File Offset: 0x00002498
		// (set) Token: 0x0600007A RID: 122 RVA: 0x000042C8 File Offset: 0x000024C8
		public Vector2 uvBottomLeftUnFlipped
		{
			get
			{
				return new Vector2(this.uv.x, this.uv.y);
			}
			set
			{
				Vector2 uvTopRightUnFlipped = this.uvTopRightUnFlipped;
				this.uv.x = value.x;
				this.uv.y = value.y;
				this.uv.width = uvTopRightUnFlipped.x - this.uv.x;
				this.uv.height = uvTopRightUnFlipped.y - this.uv.y;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00004340 File Offset: 0x00002540
		// (set) Token: 0x0600007C RID: 124 RVA: 0x0000437C File Offset: 0x0000257C
		public Vector2 uvBottomRightUnFlipped
		{
			get
			{
				return new Vector2(this.uv.x + this.uv.width, this.uv.y);
			}
			set
			{
				Vector2 uvTopRightUnFlipped = this.uvTopRightUnFlipped;
				this.uv.width = value.x - this.uv.x;
				this.uv.y = value.y;
				this.uv.height = uvTopRightUnFlipped.y - this.uv.y;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000043E0 File Offset: 0x000025E0
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00002447 File Offset: 0x00000647
		public Vector2 uvTopRightUnFlipped
		{
			get
			{
				return new Vector2(this.uv.x + this.uv.width, this.uv.y + this.uv.height);
			}
			set
			{
				this.uv.width = value.x - this.uv.x;
				this.uv.height = value.y - this.uv.y;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00004428 File Offset: 0x00002628
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00004464 File Offset: 0x00002664
		public Vector2 uvTopLeftUnFlipped
		{
			get
			{
				return new Vector2(this.uv.x, this.uv.y + this.uv.height);
			}
			set
			{
				Vector2 uvTopRightUnFlipped = this.uvTopRightUnFlipped;
				this.uv.x = value.x;
				this.uv.height = value.y - this.uv.y;
				this.uv.width = uvTopRightUnFlipped.x - this.uv.x;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000044C8 File Offset: 0x000026C8
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00002486 File Offset: 0x00000686
		public Vector2 uvBottomLeft
		{
			get
			{
				return this.uvBottomLeftUnFlipped;
			}
			set
			{
				this.uvBottomLeftUnFlipped = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000083 RID: 131 RVA: 0x000044E0 File Offset: 0x000026E0
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00004508 File Offset: 0x00002708
		public Vector2 uvBottomRight
		{
			get
			{
				return this.flipped ? this.uvTopLeftUnFlipped : this.uvBottomRightUnFlipped;
			}
			set
			{
				bool flag = this.flipped;
				if (flag)
				{
					this.uvTopLeftUnFlipped = value;
				}
				else
				{
					this.uvBottomRightUnFlipped = value;
				}
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00004534 File Offset: 0x00002734
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00002491 File Offset: 0x00000691
		public Vector2 uvTopRight
		{
			get
			{
				return this.uvTopRightUnFlipped;
			}
			set
			{
				this.uvTopRightUnFlipped = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0000454C File Offset: 0x0000274C
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00004574 File Offset: 0x00002774
		public Vector2 uvTopLeft
		{
			get
			{
				return this.flipped ? this.uvBottomRightUnFlipped : this.uvTopLeftUnFlipped;
			}
			set
			{
				bool flag = this.flipped;
				if (flag)
				{
					this.uvBottomRightUnFlipped = value;
				}
				else
				{
					this.uvTopLeftUnFlipped = value;
				}
			}
		}

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_uv;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_vert;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr_style;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr_flipped;

		// Token: 0x04000066 RID: 102
		[FieldOffset(0)]
		public int index;

		// Token: 0x04000067 RID: 103
		[FieldOffset(4)]
		public Rect uv;

		// Token: 0x04000068 RID: 104
		[FieldOffset(20)]
		public Rect vert;

		// Token: 0x04000069 RID: 105
		[FieldOffset(36)]
		public float width;

		// Token: 0x0400006A RID: 106
		[FieldOffset(40)]
		public int size;

		// Token: 0x0400006B RID: 107
		[FieldOffset(44)]
		public FontStyle style;

		// Token: 0x0400006C RID: 108
		[FieldOffset(48)]
		[MarshalAs(4)]
		public bool flipped;
	}
}
