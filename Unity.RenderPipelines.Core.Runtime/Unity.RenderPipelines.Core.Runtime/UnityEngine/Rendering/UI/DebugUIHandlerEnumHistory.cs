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
	// Token: 0x02000124 RID: 292
	public class DebugUIHandlerEnumHistory : DebugUIHandlerEnumField
	{
		// Token: 0x060012FA RID: 4858 RVA: 0x00055870 File Offset: 0x00053A70
		// Note: this type is marked as 'beforefieldinit'.
		static DebugUIHandlerEnumHistory()
		{
			Il2CppClassPointerStore<DebugUIHandlerEnumHistory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.UI", "DebugUIHandlerEnumHistory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerEnumHistory>.NativeClassPtr);
			DebugUIHandlerEnumHistory.NativeFieldInfoPtr_historyValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerEnumHistory>.NativeClassPtr, "historyValues");
			DebugUIHandlerEnumHistory.NativeFieldInfoPtr_k_XOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerEnumHistory>.NativeClassPtr, "k_XOffset");
			DebugUIHandlerEnumHistory.NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerEnumHistory>.NativeClassPtr, 100666069);
			DebugUIHandlerEnumHistory.NativeMethodInfoPtr_UpdateValueLabel_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerEnumHistory>.NativeClassPtr, 100666070);
			DebugUIHandlerEnumHistory.NativeMethodInfoPtr_RefreshAfterSanitization_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerEnumHistory>.NativeClassPtr, 100666071);
			DebugUIHandlerEnumHistory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerEnumHistory>.NativeClassPtr, 100666072);
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x00055918 File Offset: 0x00053B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980572, XrefRangeEnd = 980604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetWidget(DebugUI.Widget widget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(widget);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerEnumHistory.NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x00055968 File Offset: 0x00053B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980604, XrefRangeEnd = 980623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateValueLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerEnumHistory.NativeMethodInfoPtr_UpdateValueLabel_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x000559A4 File Offset: 0x00053BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980623, XrefRangeEnd = 980628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RefreshAfterSanitization()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerEnumHistory.NativeMethodInfoPtr_RefreshAfterSanitization_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x000559E4 File Offset: 0x00053BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUIHandlerEnumHistory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerEnumHistory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerEnumHistory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00009AB2 File Offset: 0x00007CB2
		public DebugUIHandlerEnumHistory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x00055A20 File Offset: 0x00053C20
		// (set) Token: 0x06001301 RID: 4865 RVA: 0x00009ABB File Offset: 0x00007CBB
		public unsafe Il2CppReferenceArray<Text> historyValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerEnumHistory.NativeFieldInfoPtr_historyValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerEnumHistory.NativeFieldInfoPtr_historyValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x00055A50 File Offset: 0x00053C50
		// (set) Token: 0x06001303 RID: 4867 RVA: 0x00009ADA File Offset: 0x00007CDA
		public unsafe static float k_XOffset
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DebugUIHandlerEnumHistory.NativeFieldInfoPtr_k_XOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugUIHandlerEnumHistory.NativeFieldInfoPtr_k_XOffset, (void*)(&value));
			}
		}

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeFieldInfoPtr_historyValues;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeFieldInfoPtr_k_XOffset;

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0;

		// Token: 0x04000E27 RID: 3623
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValueLabel_Public_Virtual_Void_0;

		// Token: 0x04000E28 RID: 3624
		private static readonly IntPtr NativeMethodInfoPtr_RefreshAfterSanitization_Private_IEnumerator_0;

		// Token: 0x04000E29 RID: 3625
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000219 RID: 537
		[ObfuscatedName("UnityEngine.Rendering.UI.DebugUIHandlerEnumHistory+<RefreshAfterSanitization>d__4")]
		public sealed class _RefreshAfterSanitization_d__4 : Object
		{
			// Token: 0x06001B48 RID: 6984 RVA: 0x0006F79C File Offset: 0x0006D99C
			// Note: this type is marked as 'beforefieldinit'.
			static _RefreshAfterSanitization_d__4()
			{
				Il2CppClassPointerStore<DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUIHandlerEnumHistory>.NativeClassPtr, "<RefreshAfterSanitization>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4>.NativeClassPtr);
				DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4>.NativeClassPtr, "<>1__state");
				DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4>.NativeClassPtr, "<>2__current");
				DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4>.NativeClassPtr, "<>4__this");
				DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4>.NativeClassPtr, 100666073);
				DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4>.NativeClassPtr, 100666074);
				DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4>.NativeClassPtr, 100666075);
				DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4>.NativeClassPtr, 100666076);
				DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4>.NativeClassPtr, 100666077);
				DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4>.NativeClassPtr, 100666078);
			}

			// Token: 0x06001B49 RID: 6985 RVA: 0x0006F87C File Offset: 0x0006DA7C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RefreshAfterSanitization_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B4A RID: 6986 RVA: 0x0006F8C4 File Offset: 0x0006DAC4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B4B RID: 6987 RVA: 0x0006F8F8 File Offset: 0x0006DAF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980566, XrefRangeEnd = 980567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170007B4 RID: 1972
			// (get) Token: 0x06001B4C RID: 6988 RVA: 0x0006F934 File Offset: 0x0006DB34
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001B4D RID: 6989 RVA: 0x0006F974 File Offset: 0x0006DB74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980567, XrefRangeEnd = 980572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007B5 RID: 1973
			// (get) Token: 0x06001B4E RID: 6990 RVA: 0x0006F9A8 File Offset: 0x0006DBA8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001B4F RID: 6991 RVA: 0x0000D9E2 File Offset: 0x0000BBE2
			public _RefreshAfterSanitization_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007B1 RID: 1969
			// (get) Token: 0x06001B50 RID: 6992 RVA: 0x0006F9E8 File Offset: 0x0006DBE8
			// (set) Token: 0x06001B51 RID: 6993 RVA: 0x0000D9EB File Offset: 0x0000BBEB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007B2 RID: 1970
			// (get) Token: 0x06001B52 RID: 6994 RVA: 0x0006FA10 File Offset: 0x0006DC10
			// (set) Token: 0x06001B53 RID: 6995 RVA: 0x0000DA06 File Offset: 0x0000BC06
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007B3 RID: 1971
			// (get) Token: 0x06001B54 RID: 6996 RVA: 0x0006FA40 File Offset: 0x0006DC40
			// (set) Token: 0x06001B55 RID: 6997 RVA: 0x0000DA25 File Offset: 0x0000BC25
			public unsafe DebugUIHandlerEnumHistory __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerEnumHistory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerEnumHistory._RefreshAfterSanitization_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013DF RID: 5087
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040013E0 RID: 5088
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040013E1 RID: 5089
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040013E2 RID: 5090
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040013E3 RID: 5091
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040013E4 RID: 5092
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040013E5 RID: 5093
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040013E6 RID: 5094
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040013E7 RID: 5095
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
