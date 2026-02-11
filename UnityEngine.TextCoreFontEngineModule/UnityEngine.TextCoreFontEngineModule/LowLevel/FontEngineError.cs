using System;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x02000008 RID: 8
	public enum FontEngineError
	{
		// Token: 0x04000087 RID: 135
		Success,
		// Token: 0x04000088 RID: 136
		Invalid_File_Path,
		// Token: 0x04000089 RID: 137
		Invalid_File_Format,
		// Token: 0x0400008A RID: 138
		Invalid_File_Structure,
		// Token: 0x0400008B RID: 139
		Invalid_File,
		// Token: 0x0400008C RID: 140
		Invalid_Table = 8,
		// Token: 0x0400008D RID: 141
		Invalid_Glyph_Index = 16,
		// Token: 0x0400008E RID: 142
		Invalid_Character_Code,
		// Token: 0x0400008F RID: 143
		Invalid_Pixel_Size = 23,
		// Token: 0x04000090 RID: 144
		Invalid_Library = 33,
		// Token: 0x04000091 RID: 145
		Invalid_Face = 35,
		// Token: 0x04000092 RID: 146
		Invalid_Library_or_Face = 41,
		// Token: 0x04000093 RID: 147
		Atlas_Generation_Cancelled = 100,
		// Token: 0x04000094 RID: 148
		Invalid_SharedTextureData,
		// Token: 0x04000095 RID: 149
		OpenTypeLayoutLookup_Mismatch = 116
	}
}
