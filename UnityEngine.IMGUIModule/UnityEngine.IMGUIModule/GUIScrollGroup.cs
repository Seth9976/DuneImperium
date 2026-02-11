using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000018 RID: 24
	public sealed class GUIScrollGroup : GUILayoutGroup
	{
		// Token: 0x060004FF RID: 1279 RVA: 0x00012530 File Offset: 0x00010730
		// Note: this type is marked as 'beforefieldinit'.
		static GUIScrollGroup()
		{
			Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIScrollGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr);
			GUIScrollGroup.NativeFieldInfoPtr_calcMinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "calcMinWidth");
			GUIScrollGroup.NativeFieldInfoPtr_calcMaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "calcMaxWidth");
			GUIScrollGroup.NativeFieldInfoPtr_calcMinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "calcMinHeight");
			GUIScrollGroup.NativeFieldInfoPtr_calcMaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "calcMaxHeight");
			GUIScrollGroup.NativeFieldInfoPtr_clientWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "clientWidth");
			GUIScrollGroup.NativeFieldInfoPtr_clientHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "clientHeight");
			GUIScrollGroup.NativeFieldInfoPtr_allowHorizontalScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "allowHorizontalScroll");
			GUIScrollGroup.NativeFieldInfoPtr_allowVerticalScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "allowVerticalScroll");
			GUIScrollGroup.NativeFieldInfoPtr_needsHorizontalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "needsHorizontalScrollbar");
			GUIScrollGroup.NativeFieldInfoPtr_needsVerticalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "needsVerticalScrollbar");
			GUIScrollGroup.NativeFieldInfoPtr_horizontalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "horizontalScrollbar");
			GUIScrollGroup.NativeFieldInfoPtr_verticalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "verticalScrollbar");
			GUIScrollGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, 100663645);
			GUIScrollGroup.NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, 100663646);
			GUIScrollGroup.NativeMethodInfoPtr_SetHorizontal_Public_Virtual_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, 100663647);
			GUIScrollGroup.NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, 100663648);
			GUIScrollGroup.NativeMethodInfoPtr_SetVertical_Public_Virtual_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, 100663649);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x000126B4 File Offset: 0x000108B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188183, XrefRangeEnd = 1188187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIScrollGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIScrollGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x000126F0 File Offset: 0x000108F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188187, XrefRangeEnd = 1188188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalcWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIScrollGroup.NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00012724 File Offset: 0x00010924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188188, XrefRangeEnd = 1188196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetHorizontal(float x, float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIScrollGroup.NativeMethodInfoPtr_SetHorizontal_Public_Virtual_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00012770 File Offset: 0x00010970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188196, XrefRangeEnd = 1188201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalcHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIScrollGroup.NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x000127A4 File Offset: 0x000109A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188201, XrefRangeEnd = 1188206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetVertical(float y, float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref y;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIScrollGroup.NativeMethodInfoPtr_SetVertical_Public_Virtual_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00004325 File Offset: 0x00002525
		public GUIScrollGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x000127F0 File Offset: 0x000109F0
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x0000432E File Offset: 0x0000252E
		public unsafe float calcMinWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMinWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMinWidth)) = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00012818 File Offset: 0x00010A18
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00004349 File Offset: 0x00002549
		public unsafe float calcMaxWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMaxWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMaxWidth)) = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x00012840 File Offset: 0x00010A40
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x00004364 File Offset: 0x00002564
		public unsafe float calcMinHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMinHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMinHeight)) = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00012868 File Offset: 0x00010A68
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x0000437F File Offset: 0x0000257F
		public unsafe float calcMaxHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMaxHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMaxHeight)) = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x00012890 File Offset: 0x00010A90
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x0000439A File Offset: 0x0000259A
		public unsafe float clientWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_clientWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_clientWidth)) = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x000128B8 File Offset: 0x00010AB8
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x000043B5 File Offset: 0x000025B5
		public unsafe float clientHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_clientHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_clientHeight)) = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x000128E0 File Offset: 0x00010AE0
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x000043D0 File Offset: 0x000025D0
		public unsafe bool allowHorizontalScroll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_allowHorizontalScroll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_allowHorizontalScroll)) = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00012908 File Offset: 0x00010B08
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x000043EB File Offset: 0x000025EB
		public unsafe bool allowVerticalScroll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_allowVerticalScroll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_allowVerticalScroll)) = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00012930 File Offset: 0x00010B30
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00004406 File Offset: 0x00002606
		public unsafe bool needsHorizontalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_needsHorizontalScrollbar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_needsHorizontalScrollbar)) = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00012958 File Offset: 0x00010B58
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x00004421 File Offset: 0x00002621
		public unsafe bool needsVerticalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_needsVerticalScrollbar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_needsVerticalScrollbar)) = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00012980 File Offset: 0x00010B80
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x0000443C File Offset: 0x0000263C
		public unsafe GUIStyle horizontalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_horizontalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_horizontalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x000129B0 File Offset: 0x00010BB0
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x0000445B File Offset: 0x0000265B
		public unsafe GUIStyle verticalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_verticalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_verticalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeFieldInfoPtr_calcMinWidth;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeFieldInfoPtr_calcMaxWidth;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeFieldInfoPtr_calcMinHeight;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeFieldInfoPtr_calcMaxHeight;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeFieldInfoPtr_clientWidth;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeFieldInfoPtr_clientHeight;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeFieldInfoPtr_allowHorizontalScroll;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeFieldInfoPtr_allowVerticalScroll;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeFieldInfoPtr_needsHorizontalScrollbar;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeFieldInfoPtr_needsVerticalScrollbar;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeFieldInfoPtr_horizontalScrollbar;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeFieldInfoPtr_verticalScrollbar;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_SetHorizontal_Public_Virtual_Void_Single_Single_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_SetVertical_Public_Virtual_Void_Single_Single_0;
	}
}
