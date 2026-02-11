using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace zen.src.menus
{
	// Token: 0x0200005D RID: 93
	public class ZenContinueAutoScrollOnSelect : UIBehaviour
	{
		// Token: 0x060004C8 RID: 1224 RVA: 0x0001F0F8 File Offset: 0x0001D2F8
		// Note: this type is marked as 'beforefieldinit'.
		static ZenContinueAutoScrollOnSelect()
		{
			Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.menus", "ZenContinueAutoScrollOnSelect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr);
			ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_limitToInputModuleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr, "limitToInputModuleType");
			ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_scrollDurationSecs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr, "scrollDurationSecs");
			ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr, "scrollRect");
			ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_scrollRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr, "scrollRectTransform");
			ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_contentRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr, "contentRectTransform");
			ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_itemRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr, "itemRectTransform");
			ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr, "initialized");
			ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_poolable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr, "poolable");
			ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_autoCenterWhenSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr, "autoCenterWhenSelected");
			ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_thisIsScrollTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr, "thisIsScrollTarget");
			ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_requireOnScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr, "requireOnScreen");
			ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_transformWithRectTransformParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr, "transformWithRectTransformParent");
			ZenContinueAutoScrollOnSelect.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr, 100663955);
			ZenContinueAutoScrollOnSelect.NativeMethodInfoPtr_OnSpawn_Private_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr, 100663956);
			ZenContinueAutoScrollOnSelect.NativeMethodInfoPtr_initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr, 100663957);
			ZenContinueAutoScrollOnSelect.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr, 100663958);
			ZenContinueAutoScrollOnSelect.NativeMethodInfoPtr_onSelect_Private_IEnumerator_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr, 100663959);
			ZenContinueAutoScrollOnSelect.NativeMethodInfoPtr_AutoCenterWhenSelected_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr, 100663960);
			ZenContinueAutoScrollOnSelect.NativeMethodInfoPtr_RequireOnScreen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr, 100663961);
			ZenContinueAutoScrollOnSelect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr, 100663962);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0001F2B8 File Offset: 0x0001D4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986369, XrefRangeEnd = 986388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ZenContinueAutoScrollOnSelect.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0001F2F4 File Offset: 0x0001D4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986388, XrefRangeEnd = 986389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSpawn(PoolableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenContinueAutoScrollOnSelect.NativeMethodInfoPtr_OnSpawn_Private_Void_PoolableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0001F338 File Offset: 0x0001D538
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 986440, RefRangeEnd = 986443, XrefRangeStart = 986389, XrefRangeEnd = 986440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenContinueAutoScrollOnSelect.NativeMethodInfoPtr_initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0001F36C File Offset: 0x0001D56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986443, XrefRangeEnd = 986499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenContinueAutoScrollOnSelect.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0001F3B0 File Offset: 0x0001D5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986499, XrefRangeEnd = 986504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator onSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenContinueAutoScrollOnSelect.NativeMethodInfoPtr_onSelect_Private_IEnumerator_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0001F400 File Offset: 0x0001D600
		[CallerCount(0)]
		public unsafe void AutoCenterWhenSelected(bool autoCenter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref autoCenter;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenContinueAutoScrollOnSelect.NativeMethodInfoPtr_AutoCenterWhenSelected_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0001F440 File Offset: 0x0001D640
		[CallerCount(0)]
		public unsafe void RequireOnScreen(bool require)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref require;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenContinueAutoScrollOnSelect.NativeMethodInfoPtr_RequireOnScreen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0001F480 File Offset: 0x0001D680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986504, XrefRangeEnd = 986509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ZenContinueAutoScrollOnSelect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenContinueAutoScrollOnSelect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00004328 File Offset: 0x00002528
		public ZenContinueAutoScrollOnSelect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x0001F4BC File Offset: 0x0001D6BC
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x00004331 File Offset: 0x00002531
		public unsafe string limitToInputModuleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_limitToInputModuleType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_limitToInputModuleType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x0001F4E4 File Offset: 0x0001D6E4
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x00004350 File Offset: 0x00002550
		public unsafe float scrollDurationSecs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_scrollDurationSecs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_scrollDurationSecs)) = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x0001F50C File Offset: 0x0001D70C
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x0000436B File Offset: 0x0000256B
		public unsafe ScrollRect scrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_scrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x0001F53C File Offset: 0x0001D73C
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x0000438A File Offset: 0x0000258A
		public unsafe RectTransform scrollRectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_scrollRectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_scrollRectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x0001F56C File Offset: 0x0001D76C
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x000043A9 File Offset: 0x000025A9
		public unsafe RectTransform contentRectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_contentRectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_contentRectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x0001F59C File Offset: 0x0001D79C
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x000043C8 File Offset: 0x000025C8
		public unsafe RectTransform itemRectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_itemRectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_itemRectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x0001F5CC File Offset: 0x0001D7CC
		// (set) Token: 0x060004DF RID: 1247 RVA: 0x000043E7 File Offset: 0x000025E7
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x0001F5F4 File Offset: 0x0001D7F4
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00004402 File Offset: 0x00002602
		public unsafe PoolableItem poolable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_poolable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_poolable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0001F624 File Offset: 0x0001D824
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x00004421 File Offset: 0x00002621
		public unsafe bool autoCenterWhenSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_autoCenterWhenSelected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_autoCenterWhenSelected)) = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x0001F64C File Offset: 0x0001D84C
		// (set) Token: 0x060004E5 RID: 1253 RVA: 0x0000443C File Offset: 0x0000263C
		public unsafe bool thisIsScrollTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_thisIsScrollTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_thisIsScrollTarget)) = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x0001F674 File Offset: 0x0001D874
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x00004457 File Offset: 0x00002657
		public unsafe bool requireOnScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_requireOnScreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_requireOnScreen)) = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x0001F69C File Offset: 0x0001D89C
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x00004472 File Offset: 0x00002672
		public unsafe bool transformWithRectTransformParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_transformWithRectTransformParent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect.NativeFieldInfoPtr_transformWithRectTransformParent)) = value;
			}
		}

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeFieldInfoPtr_limitToInputModuleType;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeFieldInfoPtr_scrollDurationSecs;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeFieldInfoPtr_scrollRect;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeFieldInfoPtr_scrollRectTransform;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeFieldInfoPtr_contentRectTransform;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeFieldInfoPtr_itemRectTransform;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeFieldInfoPtr_poolable;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeFieldInfoPtr_autoCenterWhenSelected;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeFieldInfoPtr_thisIsScrollTarget;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeFieldInfoPtr_requireOnScreen;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeFieldInfoPtr_transformWithRectTransformParent;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawn_Private_Void_PoolableItem_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Private_Void_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_onSelect_Private_IEnumerator_BaseEventData_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_AutoCenterWhenSelected_Public_Void_Boolean_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_RequireOnScreen_Public_Void_Boolean_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001CB RID: 459
		[ObfuscatedName("zen.src.menus.ZenContinueAutoScrollOnSelect+<onSelect>d__16")]
		public sealed class _onSelect_d__16 : global::Il2CppSystem.Object
		{
			// Token: 0x060015C6 RID: 5574 RVA: 0x000544B8 File Offset: 0x000526B8
			// Note: this type is marked as 'beforefieldinit'.
			static _onSelect_d__16()
			{
				Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect._onSelect_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect>.NativeClassPtr, "<onSelect>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect._onSelect_d__16>.NativeClassPtr);
				ZenContinueAutoScrollOnSelect._onSelect_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect._onSelect_d__16>.NativeClassPtr, "<>1__state");
				ZenContinueAutoScrollOnSelect._onSelect_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect._onSelect_d__16>.NativeClassPtr, "<>2__current");
				ZenContinueAutoScrollOnSelect._onSelect_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect._onSelect_d__16>.NativeClassPtr, "<>4__this");
				ZenContinueAutoScrollOnSelect._onSelect_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect._onSelect_d__16>.NativeClassPtr, 100663963);
				ZenContinueAutoScrollOnSelect._onSelect_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect._onSelect_d__16>.NativeClassPtr, 100663964);
				ZenContinueAutoScrollOnSelect._onSelect_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect._onSelect_d__16>.NativeClassPtr, 100663965);
				ZenContinueAutoScrollOnSelect._onSelect_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect._onSelect_d__16>.NativeClassPtr, 100663966);
				ZenContinueAutoScrollOnSelect._onSelect_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect._onSelect_d__16>.NativeClassPtr, 100663967);
				ZenContinueAutoScrollOnSelect._onSelect_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect._onSelect_d__16>.NativeClassPtr, 100663968);
			}

			// Token: 0x060015C7 RID: 5575 RVA: 0x00054598 File Offset: 0x00052798
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _onSelect_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ZenContinueAutoScrollOnSelect._onSelect_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenContinueAutoScrollOnSelect._onSelect_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060015C8 RID: 5576 RVA: 0x000545E0 File Offset: 0x000527E0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenContinueAutoScrollOnSelect._onSelect_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015C9 RID: 5577 RVA: 0x00054614 File Offset: 0x00052814
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986340, XrefRangeEnd = 986364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenContinueAutoScrollOnSelect._onSelect_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700063F RID: 1599
			// (get) Token: 0x060015CA RID: 5578 RVA: 0x00054650 File Offset: 0x00052850
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenContinueAutoScrollOnSelect._onSelect_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060015CB RID: 5579 RVA: 0x00054690 File Offset: 0x00052890
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986364, XrefRangeEnd = 986369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenContinueAutoScrollOnSelect._onSelect_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000640 RID: 1600
			// (get) Token: 0x060015CC RID: 5580 RVA: 0x000546C4 File Offset: 0x000528C4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZenContinueAutoScrollOnSelect._onSelect_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060015CD RID: 5581 RVA: 0x0000C2EB File Offset: 0x0000A4EB
			public _onSelect_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700063C RID: 1596
			// (get) Token: 0x060015CE RID: 5582 RVA: 0x00054704 File Offset: 0x00052904
			// (set) Token: 0x060015CF RID: 5583 RVA: 0x0000C2F4 File Offset: 0x0000A4F4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect._onSelect_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect._onSelect_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700063D RID: 1597
			// (get) Token: 0x060015D0 RID: 5584 RVA: 0x0005472C File Offset: 0x0005292C
			// (set) Token: 0x060015D1 RID: 5585 RVA: 0x0000C30F File Offset: 0x0000A50F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect._onSelect_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect._onSelect_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700063E RID: 1598
			// (get) Token: 0x060015D2 RID: 5586 RVA: 0x0005475C File Offset: 0x0005295C
			// (set) Token: 0x060015D3 RID: 5587 RVA: 0x0000C32E File Offset: 0x0000A52E
			public unsafe ZenContinueAutoScrollOnSelect __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect._onSelect_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ZenContinueAutoScrollOnSelect>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZenContinueAutoScrollOnSelect._onSelect_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000D36 RID: 3382
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000D37 RID: 3383
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000D38 RID: 3384
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000D39 RID: 3385
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000D3A RID: 3386
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D3B RID: 3387
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000D3C RID: 3388
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000D3D RID: 3389
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D3E RID: 3390
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
