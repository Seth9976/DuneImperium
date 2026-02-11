using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;
using UnityEngine;
using UnityEngine.EventSystems;

namespace boardgames.moz
{
	// Token: 0x02000123 RID: 291
	public class TapMoz : MonoBehaviour
	{
		// Token: 0x06000CF6 RID: 3318 RVA: 0x00046710 File Offset: 0x00044910
		// Note: this type is marked as 'beforefieldinit'.
		static TapMoz()
		{
			Il2CppClassPointerStore<TapMoz>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.moz", "TapMoz");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TapMoz>.NativeClassPtr);
			TapMoz.NativeFieldInfoPtr_disableOnClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TapMoz>.NativeClassPtr, "disableOnClick");
			TapMoz.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TapMoz>.NativeClassPtr, "view");
			TapMoz.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMoz>.NativeClassPtr, 100665176);
			TapMoz.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMoz>.NativeClassPtr, 100665177);
			TapMoz.NativeMethodInfoPtr_OnPointerClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMoz>.NativeClassPtr, 100665178);
			TapMoz.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMoz>.NativeClassPtr, 100665179);
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x000467B8 File Offset: 0x000449B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510315, XrefRangeEnd = 510319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMoz.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x000467EC File Offset: 0x000449EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510319, XrefRangeEnd = 510320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMoz.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00046830 File Offset: 0x00044A30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510387, RefRangeEnd = 510388, XrefRangeStart = 510320, XrefRangeEnd = 510387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMoz.NativeMethodInfoPtr_OnPointerClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00046864 File Offset: 0x00044A64
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TapMoz()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TapMoz>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMoz.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x0000847A File Offset: 0x0000667A
		public TapMoz(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x000468A0 File Offset: 0x00044AA0
		// (set) Token: 0x06000CFD RID: 3325 RVA: 0x00008483 File Offset: 0x00006683
		public unsafe bool disableOnClick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMoz.NativeFieldInfoPtr_disableOnClick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMoz.NativeFieldInfoPtr_disableOnClick)) = value;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x000468C8 File Offset: 0x00044AC8
		// (set) Token: 0x06000CFF RID: 3327 RVA: 0x0000849E File Offset: 0x0000669E
		public unsafe EntityView view
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMoz.NativeFieldInfoPtr_view);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMoz.NativeFieldInfoPtr_view), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeFieldInfoPtr_disableOnClick;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeFieldInfoPtr_view;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Void_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000354 RID: 852
		[ObfuscatedName("boardgames.moz.TapMoz+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002838 RID: 10296 RVA: 0x000A0E4C File Offset: 0x0009F04C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<TapMoz.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TapMoz>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TapMoz.__c__DisplayClass4_0>.NativeClassPtr);
				TapMoz.__c__DisplayClass4_0.NativeFieldInfoPtr_mozManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TapMoz.__c__DisplayClass4_0>.NativeClassPtr, "mozManager");
				TapMoz.__c__DisplayClass4_0.NativeFieldInfoPtr_entityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TapMoz.__c__DisplayClass4_0>.NativeClassPtr, "entityID");
				TapMoz.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMoz.__c__DisplayClass4_0>.NativeClassPtr, 100665180);
				TapMoz.__c__DisplayClass4_0.NativeMethodInfoPtr__OnPointerClick_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMoz.__c__DisplayClass4_0>.NativeClassPtr, 100665181);
			}

			// Token: 0x06002839 RID: 10297 RVA: 0x000A0EC8 File Offset: 0x0009F0C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TapMoz.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMoz.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600283A RID: 10298 RVA: 0x000A0F04 File Offset: 0x0009F104
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510311, XrefRangeEnd = 510315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPointerClick_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMoz.__c__DisplayClass4_0.NativeMethodInfoPtr__OnPointerClick_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600283B RID: 10299 RVA: 0x00014CB9 File Offset: 0x00012EB9
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B3F RID: 2879
			// (get) Token: 0x0600283C RID: 10300 RVA: 0x000A0F38 File Offset: 0x0009F138
			// (set) Token: 0x0600283D RID: 10301 RVA: 0x00014CC2 File Offset: 0x00012EC2
			public unsafe MozManager mozManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMoz.__c__DisplayClass4_0.NativeFieldInfoPtr_mozManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MozManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMoz.__c__DisplayClass4_0.NativeFieldInfoPtr_mozManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B40 RID: 2880
			// (get) Token: 0x0600283E RID: 10302 RVA: 0x000A0F68 File Offset: 0x0009F168
			// (set) Token: 0x0600283F RID: 10303 RVA: 0x00014CE1 File Offset: 0x00012EE1
			public unsafe string entityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMoz.__c__DisplayClass4_0.NativeFieldInfoPtr_entityID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMoz.__c__DisplayClass4_0.NativeFieldInfoPtr_entityID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001936 RID: 6454
			private static readonly IntPtr NativeFieldInfoPtr_mozManager;

			// Token: 0x04001937 RID: 6455
			private static readonly IntPtr NativeFieldInfoPtr_entityID;

			// Token: 0x04001938 RID: 6456
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001939 RID: 6457
			private static readonly IntPtr NativeMethodInfoPtr__OnPointerClick_b__0_Internal_Void_0;
		}
	}
}
