using System;
using boardgames.analytics;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.direBytes.messages
{
	// Token: 0x02000017 RID: 23
	public class AnalyticsDireByteTile : ClientAnalyticsMessage
	{
		// Token: 0x06000102 RID: 258 RVA: 0x00006714 File Offset: 0x00004914
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsDireByteTile()
		{
			Il2CppClassPointerStore<AnalyticsDireByteTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes.messages", "AnalyticsDireByteTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsDireByteTile>.NativeClassPtr);
			AnalyticsDireByteTile.NativeFieldInfoPtr_EventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsDireByteTile>.NativeClassPtr, "EventType");
			AnalyticsDireByteTile.NativeFieldInfoPtr_DisplayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsDireByteTile>.NativeClassPtr, "DisplayType");
			AnalyticsDireByteTile.NativeFieldInfoPtr_TileID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsDireByteTile>.NativeClassPtr, "TileID");
			AnalyticsDireByteTile.NativeFieldInfoPtr_TileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsDireByteTile>.NativeClassPtr, "TileName");
			AnalyticsDireByteTile.NativeFieldInfoPtr_TilePriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsDireByteTile>.NativeClassPtr, "TilePriority");
			AnalyticsDireByteTile.NativeFieldInfoPtr_TilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsDireByteTile>.NativeClassPtr, "TilePosition");
			AnalyticsDireByteTile.NativeMethodInfoPtr_get_UrlEndPoint_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsDireByteTile>.NativeClassPtr, 100663427);
			AnalyticsDireByteTile.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsDireByteTile>.NativeClassPtr, 100663428);
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000103 RID: 259 RVA: 0x000067E4 File Offset: 0x000049E4
		public unsafe string UrlEndPoint
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235005, XrefRangeEnd = 1235007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsDireByteTile.NativeMethodInfoPtr_get_UrlEndPoint_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000681C File Offset: 0x00004A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235007, XrefRangeEnd = 1235020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsDireByteTile(string eventType, string displayType, string tileID, string tileName, int priority, int position)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsDireByteTile>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tileID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tileName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsDireByteTile.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000279B File Offset: 0x0000099B
		public AnalyticsDireByteTile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000106 RID: 262 RVA: 0x000068BC File Offset: 0x00004ABC
		// (set) Token: 0x06000107 RID: 263 RVA: 0x000027A4 File Offset: 0x000009A4
		public unsafe string EventType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsDireByteTile.NativeFieldInfoPtr_EventType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsDireByteTile.NativeFieldInfoPtr_EventType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000068E4 File Offset: 0x00004AE4
		// (set) Token: 0x06000109 RID: 265 RVA: 0x000027C3 File Offset: 0x000009C3
		public unsafe string DisplayType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsDireByteTile.NativeFieldInfoPtr_DisplayType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsDireByteTile.NativeFieldInfoPtr_DisplayType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0000690C File Offset: 0x00004B0C
		// (set) Token: 0x0600010B RID: 267 RVA: 0x000027E2 File Offset: 0x000009E2
		public unsafe string TileID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsDireByteTile.NativeFieldInfoPtr_TileID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsDireByteTile.NativeFieldInfoPtr_TileID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00006934 File Offset: 0x00004B34
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00002801 File Offset: 0x00000A01
		public unsafe string TileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsDireByteTile.NativeFieldInfoPtr_TileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsDireByteTile.NativeFieldInfoPtr_TileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600010E RID: 270 RVA: 0x0000695C File Offset: 0x00004B5C
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00002820 File Offset: 0x00000A20
		public unsafe int TilePriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsDireByteTile.NativeFieldInfoPtr_TilePriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsDireByteTile.NativeFieldInfoPtr_TilePriority)) = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00006984 File Offset: 0x00004B84
		// (set) Token: 0x06000111 RID: 273 RVA: 0x0000283B File Offset: 0x00000A3B
		public unsafe int TilePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsDireByteTile.NativeFieldInfoPtr_TilePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsDireByteTile.NativeFieldInfoPtr_TilePosition)) = value;
			}
		}

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_EventType;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_DisplayType;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_TileID;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_TileName;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_TilePriority;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr_TilePosition;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_get_UrlEndPoint_Public_get_String_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Int32_Int32_0;
	}
}
