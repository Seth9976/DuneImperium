using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200010B RID: 267
	public class PanelChangedEventBase<T> : EventBase<T> where T : PanelChangedEventBase<T>, new()
	{
		// Token: 0x060014B0 RID: 5296 RVA: 0x000662B4 File Offset: 0x000644B4
		// Note: this type is marked as 'beforefieldinit'.
		static PanelChangedEventBase()
		{
			Il2CppClassPointerStore<PanelChangedEventBase<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PanelChangedEventBase`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PanelChangedEventBase<T>>.NativeClassPtr);
			PanelChangedEventBase<T>.NativeFieldInfoPtr__originPanel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelChangedEventBase<T>>.NativeClassPtr, "<originPanel>k__BackingField");
			PanelChangedEventBase<T>.NativeFieldInfoPtr__destinationPanel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelChangedEventBase<T>>.NativeClassPtr, "<destinationPanel>k__BackingField");
			PanelChangedEventBase<T>.NativeMethodInfoPtr_get_originPanel_Public_get_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelChangedEventBase<T>>.NativeClassPtr, 100666321);
			PanelChangedEventBase<T>.NativeMethodInfoPtr_set_originPanel_Private_set_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelChangedEventBase<T>>.NativeClassPtr, 100666322);
			PanelChangedEventBase<T>.NativeMethodInfoPtr_get_destinationPanel_Public_get_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelChangedEventBase<T>>.NativeClassPtr, 100666323);
			PanelChangedEventBase<T>.NativeMethodInfoPtr_set_destinationPanel_Private_set_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelChangedEventBase<T>>.NativeClassPtr, 100666324);
			PanelChangedEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelChangedEventBase<T>>.NativeClassPtr, 100666325);
			PanelChangedEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelChangedEventBase<T>>.NativeClassPtr, 100666326);
			PanelChangedEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_IPanel_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelChangedEventBase<T>>.NativeClassPtr, 100666327);
			PanelChangedEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelChangedEventBase<T>>.NativeClassPtr, 100666328);
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060014B1 RID: 5297 RVA: 0x000663E8 File Offset: 0x000645E8
		// (set) Token: 0x060014B2 RID: 5298 RVA: 0x00066428 File Offset: 0x00064628
		public unsafe IPanel originPanel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelChangedEventBase<T>.NativeMethodInfoPtr_get_originPanel_Public_get_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPanel>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelChangedEventBase<T>.NativeMethodInfoPtr_set_originPanel_Private_set_Void_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x0006646C File Offset: 0x0006466C
		// (set) Token: 0x060014B4 RID: 5300 RVA: 0x000664AC File Offset: 0x000646AC
		public unsafe IPanel destinationPanel
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelChangedEventBase<T>.NativeMethodInfoPtr_get_destinationPanel_Public_get_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPanel>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelChangedEventBase<T>.NativeMethodInfoPtr_set_destinationPanel_Private_set_Void_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x000664F0 File Offset: 0x000646F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315569, XrefRangeEnd = 315573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PanelChangedEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0006652C File Offset: 0x0006472C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315573, XrefRangeEnd = 315575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelChangedEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x00066560 File Offset: 0x00064760
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 315584, RefRangeEnd = 315586, XrefRangeStart = 315575, XrefRangeEnd = 315584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(IPanel originPanel, IPanel destinationPanel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(originPanel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationPanel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelChangedEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_IPanel_IPanel_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x000665B0 File Offset: 0x000647B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 315591, RefRangeEnd = 315595, XrefRangeStart = 315586, XrefRangeEnd = 315591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PanelChangedEventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PanelChangedEventBase<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelChangedEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x00009CF1 File Offset: 0x00007EF1
		public PanelChangedEventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x000665EC File Offset: 0x000647EC
		// (set) Token: 0x060014BB RID: 5307 RVA: 0x00009CFA File Offset: 0x00007EFA
		public unsafe IPanel _originPanel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelChangedEventBase<T>.NativeFieldInfoPtr__originPanel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelChangedEventBase<T>.NativeFieldInfoPtr__originPanel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x0006661C File Offset: 0x0006481C
		// (set) Token: 0x060014BD RID: 5309 RVA: 0x00009D19 File Offset: 0x00007F19
		public unsafe IPanel _destinationPanel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelChangedEventBase<T>.NativeFieldInfoPtr__destinationPanel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelChangedEventBase<T>.NativeFieldInfoPtr__destinationPanel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeFieldInfoPtr__originPanel_k__BackingField;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeFieldInfoPtr__destinationPanel_k__BackingField;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeMethodInfoPtr_get_originPanel_Public_get_IPanel_0;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeMethodInfoPtr_set_originPanel_Private_set_Void_IPanel_0;

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeMethodInfoPtr_get_destinationPanel_Public_get_IPanel_0;

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeMethodInfoPtr_set_destinationPanel_Private_set_Void_IPanel_0;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_IPanel_IPanel_0;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
