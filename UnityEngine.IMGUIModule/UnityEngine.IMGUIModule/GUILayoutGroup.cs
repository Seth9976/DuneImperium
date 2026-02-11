using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000017 RID: 23
	public class GUILayoutGroup : GUILayoutEntry
	{
		// Token: 0x060004C2 RID: 1218 RVA: 0x00011B6C File Offset: 0x0000FD6C
		// Note: this type is marked as 'beforefieldinit'.
		static GUILayoutGroup()
		{
			Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUILayoutGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr);
			GUILayoutGroup.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "entries");
			GUILayoutGroup.NativeFieldInfoPtr_isVertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "isVertical");
			GUILayoutGroup.NativeFieldInfoPtr_resetCoords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "resetCoords");
			GUILayoutGroup.NativeFieldInfoPtr_spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "spacing");
			GUILayoutGroup.NativeFieldInfoPtr_sameSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "sameSize");
			GUILayoutGroup.NativeFieldInfoPtr_isWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "isWindow");
			GUILayoutGroup.NativeFieldInfoPtr_windowID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "windowID");
			GUILayoutGroup.NativeFieldInfoPtr_m_Cursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_Cursor");
			GUILayoutGroup.NativeFieldInfoPtr_m_StretchableCountX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_StretchableCountX");
			GUILayoutGroup.NativeFieldInfoPtr_m_StretchableCountY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_StretchableCountY");
			GUILayoutGroup.NativeFieldInfoPtr_m_UserSpecifiedWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_UserSpecifiedWidth");
			GUILayoutGroup.NativeFieldInfoPtr_m_UserSpecifiedHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_UserSpecifiedHeight");
			GUILayoutGroup.NativeFieldInfoPtr_m_ChildMinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_ChildMinWidth");
			GUILayoutGroup.NativeFieldInfoPtr_m_ChildMaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_ChildMaxWidth");
			GUILayoutGroup.NativeFieldInfoPtr_m_ChildMinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_ChildMinHeight");
			GUILayoutGroup.NativeFieldInfoPtr_m_ChildMaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_ChildMaxHeight");
			GUILayoutGroup.NativeFieldInfoPtr_m_MarginLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_MarginLeft");
			GUILayoutGroup.NativeFieldInfoPtr_m_MarginRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_MarginRight");
			GUILayoutGroup.NativeFieldInfoPtr_m_MarginTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_MarginTop");
			GUILayoutGroup.NativeFieldInfoPtr_m_MarginBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_MarginBottom");
			GUILayoutGroup.NativeFieldInfoPtr_none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "none");
			GUILayoutGroup.NativeMethodInfoPtr_get_marginLeft_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663631);
			GUILayoutGroup.NativeMethodInfoPtr_get_marginRight_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663632);
			GUILayoutGroup.NativeMethodInfoPtr_get_marginTop_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663633);
			GUILayoutGroup.NativeMethodInfoPtr_get_marginBottom_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663634);
			GUILayoutGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663635);
			GUILayoutGroup.NativeMethodInfoPtr_ApplyOptions_Public_Virtual_Void_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663636);
			GUILayoutGroup.NativeMethodInfoPtr_ApplyStyleSettings_Protected_Virtual_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663637);
			GUILayoutGroup.NativeMethodInfoPtr_ResetCursor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663638);
			GUILayoutGroup.NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663639);
			GUILayoutGroup.NativeMethodInfoPtr_SetHorizontal_Public_Virtual_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663640);
			GUILayoutGroup.NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663641);
			GUILayoutGroup.NativeMethodInfoPtr_SetVertical_Public_Virtual_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663642);
			GUILayoutGroup.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663643);
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00011E44 File Offset: 0x00010044
		public unsafe override int marginLeft
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutGroup.NativeMethodInfoPtr_get_marginLeft_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00011E8C File Offset: 0x0001008C
		public unsafe override int marginRight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutGroup.NativeMethodInfoPtr_get_marginRight_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00011ED4 File Offset: 0x000100D4
		public unsafe override int marginTop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutGroup.NativeMethodInfoPtr_get_marginTop_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00011F1C File Offset: 0x0001011C
		public unsafe override int marginBottom
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutGroup.NativeMethodInfoPtr_get_marginBottom_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00011F64 File Offset: 0x00010164
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1187897, RefRangeEnd = 1187902, XrefRangeStart = 1187882, XrefRangeEnd = 1187897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUILayoutGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00011FA0 File Offset: 0x000101A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187902, XrefRangeEnd = 1187909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyOptions(Il2CppReferenceArray<GUILayoutOption> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutGroup.NativeMethodInfoPtr_ApplyOptions_Public_Virtual_Void_Il2CppReferenceArray_1_GUILayoutOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00011FF0 File Offset: 0x000101F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187909, XrefRangeEnd = 1187924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyStyleSettings(GUIStyle style)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(style);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutGroup.NativeMethodInfoPtr_ApplyStyleSettings_Protected_Virtual_Void_GUIStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00012040 File Offset: 0x00010240
		[CallerCount(0)]
		public unsafe void ResetCursor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutGroup.NativeMethodInfoPtr_ResetCursor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00012074 File Offset: 0x00010274
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1187975, RefRangeEnd = 1187976, XrefRangeStart = 1187924, XrefRangeEnd = 1187975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalcWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutGroup.NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x000120B0 File Offset: 0x000102B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1188039, RefRangeEnd = 1188041, XrefRangeStart = 1187976, XrefRangeEnd = 1188039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutGroup.NativeMethodInfoPtr_SetHorizontal_Public_Virtual_Void_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00012108 File Offset: 0x00010308
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1188090, RefRangeEnd = 1188091, XrefRangeStart = 1188041, XrefRangeEnd = 1188090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalcHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutGroup.NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00012144 File Offset: 0x00010344
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1188130, RefRangeEnd = 1188131, XrefRangeStart = 1188091, XrefRangeEnd = 1188130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutGroup.NativeMethodInfoPtr_SetVertical_Public_Virtual_Void_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0001219C File Offset: 0x0001039C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188131, XrefRangeEnd = 1188183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutGroup.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x000040B3 File Offset: 0x000022B3
		public GUILayoutGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x000121E0 File Offset: 0x000103E0
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x000040BC File Offset: 0x000022BC
		public unsafe List<GUILayoutEntry> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GUILayoutEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00012210 File Offset: 0x00010410
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x000040DB File Offset: 0x000022DB
		public unsafe bool isVertical
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_isVertical);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_isVertical)) = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00012238 File Offset: 0x00010438
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x000040F6 File Offset: 0x000022F6
		public unsafe bool resetCoords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_resetCoords);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_resetCoords)) = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00012260 File Offset: 0x00010460
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00004111 File Offset: 0x00002311
		public unsafe float spacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_spacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_spacing)) = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00012288 File Offset: 0x00010488
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x0000412C File Offset: 0x0000232C
		public unsafe bool sameSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_sameSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_sameSize)) = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x000122B0 File Offset: 0x000104B0
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00004147 File Offset: 0x00002347
		public unsafe bool isWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_isWindow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_isWindow)) = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x000122D8 File Offset: 0x000104D8
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00004162 File Offset: 0x00002362
		public unsafe int windowID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_windowID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_windowID)) = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00012300 File Offset: 0x00010500
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x0000417D File Offset: 0x0000237D
		public unsafe int m_Cursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_Cursor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_Cursor)) = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00012328 File Offset: 0x00010528
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00004198 File Offset: 0x00002398
		public unsafe int m_StretchableCountX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_StretchableCountX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_StretchableCountX)) = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00012350 File Offset: 0x00010550
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x000041B3 File Offset: 0x000023B3
		public unsafe int m_StretchableCountY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_StretchableCountY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_StretchableCountY)) = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00012378 File Offset: 0x00010578
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x000041CE File Offset: 0x000023CE
		public unsafe bool m_UserSpecifiedWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_UserSpecifiedWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_UserSpecifiedWidth)) = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x000123A0 File Offset: 0x000105A0
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x000041E9 File Offset: 0x000023E9
		public unsafe bool m_UserSpecifiedHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_UserSpecifiedHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_UserSpecifiedHeight)) = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x000123C8 File Offset: 0x000105C8
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x00004204 File Offset: 0x00002404
		public unsafe float m_ChildMinWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_ChildMinWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_ChildMinWidth)) = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x000123F0 File Offset: 0x000105F0
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x0000421F File Offset: 0x0000241F
		public unsafe float m_ChildMaxWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_ChildMaxWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_ChildMaxWidth)) = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x00012418 File Offset: 0x00010618
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x0000423A File Offset: 0x0000243A
		public unsafe float m_ChildMinHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_ChildMinHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_ChildMinHeight)) = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00012440 File Offset: 0x00010640
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x00004255 File Offset: 0x00002455
		public unsafe float m_ChildMaxHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_ChildMaxHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_ChildMaxHeight)) = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00012468 File Offset: 0x00010668
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x00004270 File Offset: 0x00002470
		public unsafe int m_MarginLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_MarginLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_MarginLeft)) = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00012490 File Offset: 0x00010690
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x0000428B File Offset: 0x0000248B
		public unsafe int m_MarginRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_MarginRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_MarginRight)) = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x000124B8 File Offset: 0x000106B8
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x000042A6 File Offset: 0x000024A6
		public unsafe int m_MarginTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_MarginTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_MarginTop)) = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x000124E0 File Offset: 0x000106E0
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x000042C1 File Offset: 0x000024C1
		public unsafe int m_MarginBottom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_MarginBottom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_MarginBottom)) = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00012508 File Offset: 0x00010708
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x000042DC File Offset: 0x000024DC
		public unsafe static GUILayoutEntry none
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUILayoutGroup.NativeFieldInfoPtr_none, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUILayoutEntry>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUILayoutGroup.NativeFieldInfoPtr_none, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x000042EE File Offset: 0x000024EE
		public Rect PeekNext()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x000042FB File Offset: 0x000024FB
		public GUILayoutEntry GetNext()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00004308 File Offset: 0x00002508
		public Rect GetLast()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00004315 File Offset: 0x00002515
		public void Add(GUILayoutEntry e)
		{
			this.entries.Add(e);
		}

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeFieldInfoPtr_isVertical;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeFieldInfoPtr_resetCoords;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeFieldInfoPtr_spacing;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeFieldInfoPtr_sameSize;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeFieldInfoPtr_isWindow;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeFieldInfoPtr_windowID;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeFieldInfoPtr_m_Cursor;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeFieldInfoPtr_m_StretchableCountX;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeFieldInfoPtr_m_StretchableCountY;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeFieldInfoPtr_m_UserSpecifiedWidth;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeFieldInfoPtr_m_UserSpecifiedHeight;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildMinWidth;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildMaxWidth;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildMinHeight;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildMaxHeight;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeFieldInfoPtr_m_MarginLeft;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeFieldInfoPtr_m_MarginRight;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeFieldInfoPtr_m_MarginTop;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeFieldInfoPtr_m_MarginBottom;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeFieldInfoPtr_none;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_get_marginLeft_Public_Virtual_get_Int32_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_get_marginRight_Public_Virtual_get_Int32_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_get_marginTop_Public_Virtual_get_Int32_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_get_marginBottom_Public_Virtual_get_Int32_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr_ApplyOptions_Public_Virtual_Void_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_ApplyStyleSettings_Protected_Virtual_Void_GUIStyle_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_ResetCursor_Public_Void_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_SetHorizontal_Public_Virtual_Void_Single_Single_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_SetVertical_Public_Virtual_Void_Single_Single_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
