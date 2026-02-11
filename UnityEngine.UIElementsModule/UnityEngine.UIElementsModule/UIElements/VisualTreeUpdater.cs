using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.UIElements
{
	// Token: 0x0200023D RID: 573
	public sealed class VisualTreeUpdater : Object
	{
		// Token: 0x06002A4D RID: 10829 RVA: 0x000B82D0 File Offset: 0x000B64D0
		// Note: this type is marked as 'beforefieldinit'.
		static VisualTreeUpdater()
		{
			Il2CppClassPointerStore<VisualTreeUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualTreeUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualTreeUpdater>.NativeClassPtr);
			VisualTreeUpdater.NativeFieldInfoPtr_m_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeUpdater>.NativeClassPtr, "m_Panel");
			VisualTreeUpdater.NativeFieldInfoPtr_m_UpdaterArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeUpdater>.NativeClassPtr, "m_UpdaterArray");
			VisualTreeUpdater.NativeMethodInfoPtr__ctor_Public_Void_BaseVisualElementPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeUpdater>.NativeClassPtr, 100669619);
			VisualTreeUpdater.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeUpdater>.NativeClassPtr, 100669620);
			VisualTreeUpdater.NativeMethodInfoPtr_UpdateVisualTreePhase_Public_Void_VisualTreeUpdatePhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeUpdater>.NativeClassPtr, 100669621);
			VisualTreeUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Void_VisualElement_VersionChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeUpdater>.NativeClassPtr, 100669622);
			VisualTreeUpdater.NativeMethodInfoPtr_SetUpdater_Public_Void_VisualTreeUpdatePhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeUpdater>.NativeClassPtr, 100669623);
			VisualTreeUpdater.NativeMethodInfoPtr_GetUpdater_Public_IVisualTreeUpdater_VisualTreeUpdatePhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeUpdater>.NativeClassPtr, 100669624);
			VisualTreeUpdater.NativeMethodInfoPtr_SetDefaultUpdaters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeUpdater>.NativeClassPtr, 100669625);
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x000B83B4 File Offset: 0x000B65B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347588, RefRangeEnd = 347589, XrefRangeStart = 347556, XrefRangeEnd = 347588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualTreeUpdater(BaseVisualElementPanel panel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualTreeUpdater>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeUpdater.NativeMethodInfoPtr__ctor_Public_Void_BaseVisualElementPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x000B8400 File Offset: 0x000B6600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347592, RefRangeEnd = 347593, XrefRangeStart = 347589, XrefRangeEnd = 347592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeUpdater.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x000B8434 File Offset: 0x000B6634
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 347607, RefRangeEnd = 347623, XrefRangeStart = 347593, XrefRangeEnd = 347607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisualTreePhase(VisualTreeUpdatePhase phase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref phase;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeUpdater.NativeMethodInfoPtr_UpdateVisualTreePhase_Public_Void_VisualTreeUpdatePhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x000B8474 File Offset: 0x000B6674
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347626, RefRangeEnd = 347627, XrefRangeStart = 347623, XrefRangeEnd = 347626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref versionChangeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Void_VisualElement_VersionChangeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A52 RID: 10834 RVA: 0x000B84C4 File Offset: 0x000B66C4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 347639, RefRangeEnd = 347653, XrefRangeStart = 347627, XrefRangeEnd = 347639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUpdater<T>(VisualTreeUpdatePhase phase) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref phase;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeUpdater.MethodInfoStoreGeneric_SetUpdater_Public_Void_VisualTreeUpdatePhase_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x000B8504 File Offset: 0x000B6704
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347653, RefRangeEnd = 347654, XrefRangeStart = 347653, XrefRangeEnd = 347653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref phase;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeUpdater.NativeMethodInfoPtr_GetUpdater_Public_IVisualTreeUpdater_VisualTreeUpdatePhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVisualTreeUpdater>(intPtr3) : null;
			}
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x000B8550 File Offset: 0x000B6750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347654, XrefRangeEnd = 347675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefaultUpdaters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeUpdater.NativeMethodInfoPtr_SetDefaultUpdaters_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x000110E0 File Offset: 0x0000F2E0
		public VisualTreeUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06002A56 RID: 10838 RVA: 0x000B8584 File Offset: 0x000B6784
		// (set) Token: 0x06002A57 RID: 10839 RVA: 0x000110E9 File Offset: 0x0000F2E9
		public unsafe BaseVisualElementPanel m_Panel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeUpdater.NativeFieldInfoPtr_m_Panel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseVisualElementPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeUpdater.NativeFieldInfoPtr_m_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06002A58 RID: 10840 RVA: 0x000B85B4 File Offset: 0x000B67B4
		// (set) Token: 0x06002A59 RID: 10841 RVA: 0x00011108 File Offset: 0x0000F308
		public unsafe VisualTreeUpdater.UpdaterArray m_UpdaterArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeUpdater.NativeFieldInfoPtr_m_UpdaterArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualTreeUpdater.UpdaterArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeUpdater.NativeFieldInfoPtr_m_UpdaterArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x000B85E4 File Offset: 0x000B67E4
		public void UpdateVisualTree()
		{
			for (int i = 0; i < 7; i++)
			{
				IVisualTreeUpdater visualTreeUpdater = this.m_UpdaterArray[i];
				using (visualTreeUpdater.profilerMarker.Auto())
				{
					visualTreeUpdater.Update();
				}
			}
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x00011127 File Offset: 0x0000F327
		public void SetUpdater(IVisualTreeUpdater updater, VisualTreeUpdatePhase phase)
		{
			IVisualTreeUpdater visualTreeUpdater = this.m_UpdaterArray[phase];
			if (visualTreeUpdater != null)
			{
				visualTreeUpdater.Dispose();
			}
			updater.panel = this.m_Panel;
			this.m_UpdaterArray[phase] = updater;
		}

		// Token: 0x04001E1A RID: 7706
		private static readonly IntPtr NativeFieldInfoPtr_m_Panel;

		// Token: 0x04001E1B RID: 7707
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdaterArray;

		// Token: 0x04001E1C RID: 7708
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BaseVisualElementPanel_0;

		// Token: 0x04001E1D RID: 7709
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001E1E RID: 7710
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisualTreePhase_Public_Void_VisualTreeUpdatePhase_0;

		// Token: 0x04001E1F RID: 7711
		private static readonly IntPtr NativeMethodInfoPtr_OnVersionChanged_Public_Void_VisualElement_VersionChangeType_0;

		// Token: 0x04001E20 RID: 7712
		private static readonly IntPtr NativeMethodInfoPtr_SetUpdater_Public_Void_VisualTreeUpdatePhase_0;

		// Token: 0x04001E21 RID: 7713
		private static readonly IntPtr NativeMethodInfoPtr_GetUpdater_Public_IVisualTreeUpdater_VisualTreeUpdatePhase_0;

		// Token: 0x04001E22 RID: 7714
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultUpdaters_Private_Void_0;

		// Token: 0x02000537 RID: 1335
		public class UpdaterArray : Object
		{
			// Token: 0x060040B1 RID: 16561 RVA: 0x00100610 File Offset: 0x000FE810
			// Note: this type is marked as 'beforefieldinit'.
			static UpdaterArray()
			{
				Il2CppClassPointerStore<VisualTreeUpdater.UpdaterArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualTreeUpdater>.NativeClassPtr, "UpdaterArray");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualTreeUpdater.UpdaterArray>.NativeClassPtr);
				VisualTreeUpdater.UpdaterArray.NativeFieldInfoPtr_m_VisualTreeUpdaters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeUpdater.UpdaterArray>.NativeClassPtr, "m_VisualTreeUpdaters");
				VisualTreeUpdater.UpdaterArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeUpdater.UpdaterArray>.NativeClassPtr, 100669626);
				VisualTreeUpdater.UpdaterArray.NativeMethodInfoPtr_set_Item_Public_set_Void_VisualTreeUpdatePhase_IVisualTreeUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeUpdater.UpdaterArray>.NativeClassPtr, 100669627);
				VisualTreeUpdater.UpdaterArray.NativeMethodInfoPtr_get_Item_Public_get_IVisualTreeUpdater_VisualTreeUpdatePhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeUpdater.UpdaterArray>.NativeClassPtr, 100669628);
				VisualTreeUpdater.UpdaterArray.NativeMethodInfoPtr_get_Item_Public_get_IVisualTreeUpdater_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeUpdater.UpdaterArray>.NativeClassPtr, 100669629);
			}

			// Token: 0x060040B2 RID: 16562 RVA: 0x001006A0 File Offset: 0x000FE8A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347544, XrefRangeEnd = 347549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UpdaterArray()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualTreeUpdater.UpdaterArray>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeUpdater.UpdaterArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700135E RID: 4958
			public unsafe IVisualTreeUpdater this[VisualTreeUpdatePhase phase]
			{
				[CallerCount(11)]
				[CachedScanResults(RefRangeStart = 312068, RefRangeEnd = 312079, XrefRangeStart = 312068, XrefRangeEnd = 312079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref phase;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeUpdater.UpdaterArray.NativeMethodInfoPtr_get_Item_Public_get_IVisualTreeUpdater_VisualTreeUpdatePhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVisualTreeUpdater>(intPtr3) : null;
					}
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 347555, RefRangeEnd = 347556, XrefRangeStart = 347549, XrefRangeEnd = 347555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref phase;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeUpdater.UpdaterArray.NativeMethodInfoPtr_set_Item_Public_set_Void_VisualTreeUpdatePhase_IVisualTreeUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700135F RID: 4959
			public unsafe IVisualTreeUpdater this[int index]
			{
				[CallerCount(11)]
				[CachedScanResults(RefRangeStart = 312068, RefRangeEnd = 312079, XrefRangeStart = 312068, XrefRangeEnd = 312079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeUpdater.UpdaterArray.NativeMethodInfoPtr_get_Item_Public_get_IVisualTreeUpdater_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVisualTreeUpdater>(intPtr3) : null;
					}
				}
			}

			// Token: 0x060040B6 RID: 16566 RVA: 0x0001B3E1 File Offset: 0x000195E1
			public UpdaterArray(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700135D RID: 4957
			// (get) Token: 0x060040B7 RID: 16567 RVA: 0x001007C4 File Offset: 0x000FE9C4
			// (set) Token: 0x060040B8 RID: 16568 RVA: 0x0001B3EA File Offset: 0x000195EA
			public unsafe Il2CppReferenceArray<IVisualTreeUpdater> m_VisualTreeUpdaters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeUpdater.UpdaterArray.NativeFieldInfoPtr_m_VisualTreeUpdaters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IVisualTreeUpdater>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeUpdater.UpdaterArray.NativeFieldInfoPtr_m_VisualTreeUpdaters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D8A RID: 11658
			private static readonly IntPtr NativeFieldInfoPtr_m_VisualTreeUpdaters;

			// Token: 0x04002D8B RID: 11659
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D8C RID: 11660
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_VisualTreeUpdatePhase_IVisualTreeUpdater_0;

			// Token: 0x04002D8D RID: 11661
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_IVisualTreeUpdater_VisualTreeUpdatePhase_0;

			// Token: 0x04002D8E RID: 11662
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_IVisualTreeUpdater_Int32_0;
		}

		// Token: 0x02000538 RID: 1336
		private sealed class MethodInfoStoreGeneric_SetUpdater_Public_Void_VisualTreeUpdatePhase_0<T>
		{
			// Token: 0x04002D8F RID: 11663
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(VisualTreeUpdater.NativeMethodInfoPtr_SetUpdater_Public_Void_VisualTreeUpdatePhase_0, Il2CppClassPointerStore<VisualTreeUpdater>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
