using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace lotus.scenes
{
	// Token: 0x020000E2 RID: 226
	public class PreviousSceneState : Object
	{
		// Token: 0x06000B27 RID: 2855 RVA: 0x000348CC File Offset: 0x00032ACC
		// Note: this type is marked as 'beforefieldinit'.
		static PreviousSceneState()
		{
			Il2CppClassPointerStore<PreviousSceneState>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.scenes", "PreviousSceneState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreviousSceneState>.NativeClassPtr);
			PreviousSceneState.NativeFieldInfoPtr__ResetStack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviousSceneState>.NativeClassPtr, "<ResetStack>k__BackingField");
			PreviousSceneState.NativeFieldInfoPtr_previousScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviousSceneState>.NativeClassPtr, "previousScene");
			PreviousSceneState.NativeMethodInfoPtr_get_ResetStack_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviousSceneState>.NativeClassPtr, 100665073);
			PreviousSceneState.NativeMethodInfoPtr_set_ResetStack_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviousSceneState>.NativeClassPtr, 100665074);
			PreviousSceneState.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviousSceneState>.NativeClassPtr, 100665075);
			PreviousSceneState.NativeMethodInfoPtr_RestoreState_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviousSceneState>.NativeClassPtr, 100665076);
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x00034974 File Offset: 0x00032B74
		// (set) Token: 0x06000B29 RID: 2857 RVA: 0x000349B0 File Offset: 0x00032BB0
		public unsafe virtual bool ResetStack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreviousSceneState.NativeMethodInfoPtr_get_ResetStack_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreviousSceneState.NativeMethodInfoPtr_set_ResetStack_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x000349F0 File Offset: 0x00032BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994455, XrefRangeEnd = 994457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreviousSceneState(string previousScene, bool resetStack = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreviousSceneState>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(previousScene);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resetStack;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreviousSceneState.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00034A4C File Offset: 0x00032C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994457, XrefRangeEnd = 994462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator RestoreState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreviousSceneState.NativeMethodInfoPtr_RestoreState_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00007194 File Offset: 0x00005394
		public PreviousSceneState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x00034A8C File Offset: 0x00032C8C
		// (set) Token: 0x06000B2E RID: 2862 RVA: 0x0000719D File Offset: 0x0000539D
		public unsafe bool _ResetStack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreviousSceneState.NativeFieldInfoPtr__ResetStack_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreviousSceneState.NativeFieldInfoPtr__ResetStack_k__BackingField)) = value;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x00034AB4 File Offset: 0x00032CB4
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x000071B8 File Offset: 0x000053B8
		public unsafe string previousScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreviousSceneState.NativeFieldInfoPtr_previousScene);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreviousSceneState.NativeFieldInfoPtr_previousScene), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeFieldInfoPtr__ResetStack_k__BackingField;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeFieldInfoPtr_previousScene;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeMethodInfoPtr_get_ResetStack_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeMethodInfoPtr_set_ResetStack_Private_set_Void_Boolean_0;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeMethodInfoPtr_RestoreState_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x02000240 RID: 576
		[ObfuscatedName("lotus.scenes.PreviousSceneState+<RestoreState>d__6")]
		public sealed class _RestoreState_d__6 : Object
		{
			// Token: 0x06001AA9 RID: 6825 RVA: 0x0006371C File Offset: 0x0006191C
			// Note: this type is marked as 'beforefieldinit'.
			static _RestoreState_d__6()
			{
				Il2CppClassPointerStore<PreviousSceneState._RestoreState_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreviousSceneState>.NativeClassPtr, "<RestoreState>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreviousSceneState._RestoreState_d__6>.NativeClassPtr);
				PreviousSceneState._RestoreState_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviousSceneState._RestoreState_d__6>.NativeClassPtr, "<>1__state");
				PreviousSceneState._RestoreState_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviousSceneState._RestoreState_d__6>.NativeClassPtr, "<>2__current");
				PreviousSceneState._RestoreState_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviousSceneState._RestoreState_d__6>.NativeClassPtr, "<>4__this");
				PreviousSceneState._RestoreState_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviousSceneState._RestoreState_d__6>.NativeClassPtr, 100665077);
				PreviousSceneState._RestoreState_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviousSceneState._RestoreState_d__6>.NativeClassPtr, 100665078);
				PreviousSceneState._RestoreState_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviousSceneState._RestoreState_d__6>.NativeClassPtr, 100665079);
				PreviousSceneState._RestoreState_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviousSceneState._RestoreState_d__6>.NativeClassPtr, 100665080);
				PreviousSceneState._RestoreState_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviousSceneState._RestoreState_d__6>.NativeClassPtr, 100665081);
				PreviousSceneState._RestoreState_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviousSceneState._RestoreState_d__6>.NativeClassPtr, 100665082);
			}

			// Token: 0x06001AAA RID: 6826 RVA: 0x000637FC File Offset: 0x000619FC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RestoreState_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreviousSceneState._RestoreState_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreviousSceneState._RestoreState_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001AAB RID: 6827 RVA: 0x00063844 File Offset: 0x00061A44
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreviousSceneState._RestoreState_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AAC RID: 6828 RVA: 0x00063878 File Offset: 0x00061A78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994441, XrefRangeEnd = 994450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreviousSceneState._RestoreState_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170007D4 RID: 2004
			// (get) Token: 0x06001AAD RID: 6829 RVA: 0x000638B4 File Offset: 0x00061AB4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreviousSceneState._RestoreState_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001AAE RID: 6830 RVA: 0x000638F4 File Offset: 0x00061AF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994450, XrefRangeEnd = 994455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreviousSceneState._RestoreState_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007D5 RID: 2005
			// (get) Token: 0x06001AAF RID: 6831 RVA: 0x00063928 File Offset: 0x00061B28
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreviousSceneState._RestoreState_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001AB0 RID: 6832 RVA: 0x0000E84B File Offset: 0x0000CA4B
			public _RestoreState_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007D1 RID: 2001
			// (get) Token: 0x06001AB1 RID: 6833 RVA: 0x00063968 File Offset: 0x00061B68
			// (set) Token: 0x06001AB2 RID: 6834 RVA: 0x0000E854 File Offset: 0x0000CA54
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreviousSceneState._RestoreState_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreviousSceneState._RestoreState_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007D2 RID: 2002
			// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x00063990 File Offset: 0x00061B90
			// (set) Token: 0x06001AB4 RID: 6836 RVA: 0x0000E86F File Offset: 0x0000CA6F
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreviousSceneState._RestoreState_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreviousSceneState._RestoreState_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007D3 RID: 2003
			// (get) Token: 0x06001AB5 RID: 6837 RVA: 0x000639C0 File Offset: 0x00061BC0
			// (set) Token: 0x06001AB6 RID: 6838 RVA: 0x0000E88E File Offset: 0x0000CA8E
			public unsafe PreviousSceneState __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreviousSceneState._RestoreState_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PreviousSceneState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreviousSceneState._RestoreState_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400101F RID: 4127
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001020 RID: 4128
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001021 RID: 4129
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001022 RID: 4130
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001023 RID: 4131
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001024 RID: 4132
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001025 RID: 4133
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001026 RID: 4134
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001027 RID: 4135
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
