using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	// Token: 0x02000136 RID: 310
	public class DebugUIHandlerToggleHistory : DebugUIHandlerToggle
	{
		// Token: 0x0600141C RID: 5148 RVA: 0x000596C0 File Offset: 0x000578C0
		// Note: this type is marked as 'beforefieldinit'.
		static DebugUIHandlerToggleHistory()
		{
			Il2CppClassPointerStore<DebugUIHandlerToggleHistory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.UI", "DebugUIHandlerToggleHistory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerToggleHistory>.NativeClassPtr);
			DebugUIHandlerToggleHistory.NativeFieldInfoPtr_historyToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerToggleHistory>.NativeClassPtr, "historyToggles");
			DebugUIHandlerToggleHistory.NativeFieldInfoPtr_k_XOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerToggleHistory>.NativeClassPtr, "k_XOffset");
			DebugUIHandlerToggleHistory.NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerToggleHistory>.NativeClassPtr, 100666194);
			DebugUIHandlerToggleHistory.NativeMethodInfoPtr_UpdateValueLabel_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerToggleHistory>.NativeClassPtr, 100666195);
			DebugUIHandlerToggleHistory.NativeMethodInfoPtr_RefreshAfterSanitization_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerToggleHistory>.NativeClassPtr, 100666196);
			DebugUIHandlerToggleHistory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerToggleHistory>.NativeClassPtr, 100666197);
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x00059768 File Offset: 0x00057968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981307, XrefRangeEnd = 981364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetWidget(DebugUI.Widget widget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(widget);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerToggleHistory.NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x000597B8 File Offset: 0x000579B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981364, XrefRangeEnd = 981389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateValueLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerToggleHistory.NativeMethodInfoPtr_UpdateValueLabel_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x000597F4 File Offset: 0x000579F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981389, XrefRangeEnd = 981394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RefreshAfterSanitization()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerToggleHistory.NativeMethodInfoPtr_RefreshAfterSanitization_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x00059834 File Offset: 0x00057A34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 979810, RefRangeEnd = 979814, XrefRangeStart = 979810, XrefRangeEnd = 979814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUIHandlerToggleHistory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerToggleHistory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerToggleHistory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x0000A324 File Offset: 0x00008524
		public DebugUIHandlerToggleHistory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x00059870 File Offset: 0x00057A70
		// (set) Token: 0x06001423 RID: 5155 RVA: 0x0000A32D File Offset: 0x0000852D
		public unsafe Il2CppReferenceArray<Toggle> historyToggles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerToggleHistory.NativeFieldInfoPtr_historyToggles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Toggle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerToggleHistory.NativeFieldInfoPtr_historyToggles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x000598A0 File Offset: 0x00057AA0
		// (set) Token: 0x06001425 RID: 5157 RVA: 0x0000A34C File Offset: 0x0000854C
		public unsafe static float k_XOffset
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DebugUIHandlerToggleHistory.NativeFieldInfoPtr_k_XOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugUIHandlerToggleHistory.NativeFieldInfoPtr_k_XOffset, (void*)(&value));
			}
		}

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeFieldInfoPtr_historyToggles;

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeFieldInfoPtr_k_XOffset;

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0;

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValueLabel_FamOrAssem_Virtual_Void_0;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeMethodInfoPtr_RefreshAfterSanitization_Private_IEnumerator_0;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200021C RID: 540
		[ObfuscatedName("UnityEngine.Rendering.UI.DebugUIHandlerToggleHistory+<RefreshAfterSanitization>d__4")]
		public sealed class _RefreshAfterSanitization_d__4 : Object
		{
			// Token: 0x06001B62 RID: 7010 RVA: 0x0006FCB8 File Offset: 0x0006DEB8
			// Note: this type is marked as 'beforefieldinit'.
			static _RefreshAfterSanitization_d__4()
			{
				Il2CppClassPointerStore<DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUIHandlerToggleHistory>.NativeClassPtr, "<RefreshAfterSanitization>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4>.NativeClassPtr);
				DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4>.NativeClassPtr, "<>1__state");
				DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4>.NativeClassPtr, "<>2__current");
				DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4>.NativeClassPtr, "<>4__this");
				DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4>.NativeClassPtr, 100666198);
				DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4>.NativeClassPtr, 100666199);
				DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4>.NativeClassPtr, 100666200);
				DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4>.NativeClassPtr, 100666201);
				DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4>.NativeClassPtr, 100666202);
				DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4>.NativeClassPtr, 100666203);
			}

			// Token: 0x06001B63 RID: 7011 RVA: 0x0006FD98 File Offset: 0x0006DF98
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RefreshAfterSanitization_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B64 RID: 7012 RVA: 0x0006FDE0 File Offset: 0x0006DFE0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B65 RID: 7013 RVA: 0x0006FE14 File Offset: 0x0006E014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981300, XrefRangeEnd = 981302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170007BB RID: 1979
			// (get) Token: 0x06001B66 RID: 7014 RVA: 0x0006FE50 File Offset: 0x0006E050
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001B67 RID: 7015 RVA: 0x0006FE90 File Offset: 0x0006E090
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981302, XrefRangeEnd = 981307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007BC RID: 1980
			// (get) Token: 0x06001B68 RID: 7016 RVA: 0x0006FEC4 File Offset: 0x0006E0C4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001B69 RID: 7017 RVA: 0x0000DA94 File Offset: 0x0000BC94
			public _RefreshAfterSanitization_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007B8 RID: 1976
			// (get) Token: 0x06001B6A RID: 7018 RVA: 0x0006FF04 File Offset: 0x0006E104
			// (set) Token: 0x06001B6B RID: 7019 RVA: 0x0000DA9D File Offset: 0x0000BC9D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007B9 RID: 1977
			// (get) Token: 0x06001B6C RID: 7020 RVA: 0x0006FF2C File Offset: 0x0006E12C
			// (set) Token: 0x06001B6D RID: 7021 RVA: 0x0000DAB8 File Offset: 0x0000BCB8
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007BA RID: 1978
			// (get) Token: 0x06001B6E RID: 7022 RVA: 0x0006FF5C File Offset: 0x0006E15C
			// (set) Token: 0x06001B6F RID: 7023 RVA: 0x0000DAD7 File Offset: 0x0000BCD7
			public unsafe DebugUIHandlerToggleHistory __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerToggleHistory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerToggleHistory._RefreshAfterSanitization_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013EE RID: 5102
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040013EF RID: 5103
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040013F0 RID: 5104
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040013F1 RID: 5105
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040013F2 RID: 5106
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040013F3 RID: 5107
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040013F4 RID: 5108
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040013F5 RID: 5109
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040013F6 RID: 5110
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
