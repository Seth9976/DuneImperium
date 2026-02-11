using System;
using System.Runtime.InteropServices;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.data.async
{
	// Token: 0x020001E8 RID: 488
	public class LoadAsyncData : Command
	{
		// Token: 0x06001A9C RID: 6812 RVA: 0x0007DFB4 File Offset: 0x0007C1B4
		// Note: this type is marked as 'beforefieldinit'.
		static LoadAsyncData()
		{
			Il2CppClassPointerStore<LoadAsyncData>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.async", "LoadAsyncData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadAsyncData>.NativeClassPtr);
			LoadAsyncData.NativeFieldInfoPtr_Total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAsyncData>.NativeClassPtr, "Total");
			LoadAsyncData.NativeFieldInfoPtr_uninitializedDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAsyncData>.NativeClassPtr, "uninitializedDatas");
			LoadAsyncData.NativeMethodInfoPtr_get_PendingData_Public_get_ICollection_1_IAsyncData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncData>.NativeClassPtr, 100667517);
			LoadAsyncData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_IAsyncData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncData>.NativeClassPtr, 100667518);
			LoadAsyncData.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IAsyncData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncData>.NativeClassPtr, 100667519);
			LoadAsyncData.NativeMethodInfoPtr_get_Remaining_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncData>.NativeClassPtr, 100667520);
			LoadAsyncData.NativeMethodInfoPtr_GetPercent_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncData>.NativeClassPtr, 100667521);
			LoadAsyncData.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncData>.NativeClassPtr, 100667522);
			LoadAsyncData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncData>.NativeClassPtr, 100667523);
			LoadAsyncData.NativeMethodInfoPtr_RequestFinished_Private_Static_Boolean_IAsyncData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncData>.NativeClassPtr, 100667524);
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06001A9D RID: 6813 RVA: 0x0007E0AC File Offset: 0x0007C2AC
		public unsafe ICollection<IAsyncData> PendingData
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncData.NativeMethodInfoPtr_get_PendingData_Public_get_ICollection_1_IAsyncData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<IAsyncData>>(intPtr3) : null;
			}
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x0007E0EC File Offset: 0x0007C2EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 883857, RefRangeEnd = 883858, XrefRangeStart = 883848, XrefRangeEnd = 883857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadAsyncData([Optional] Il2CppReferenceArray<IAsyncData> datas)
		{
			if (datas == null)
			{
				datas = new Il2CppReferenceArray<IAsyncData>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadAsyncData>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(datas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_IAsyncData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x0007E144 File Offset: 0x0007C344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883858, XrefRangeEnd = 883867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadAsyncData(IEnumerable<IAsyncData> datas)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadAsyncData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(datas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncData.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IAsyncData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x0007E190 File Offset: 0x0007C390
		public unsafe int Remaining
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 883868, RefRangeEnd = 883869, XrefRangeStart = 883867, XrefRangeEnd = 883868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncData.NativeMethodInfoPtr_get_Remaining_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x0007E1CC File Offset: 0x0007C3CC
		[CallerCount(0)]
		public unsafe virtual float GetPercent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncData.NativeMethodInfoPtr_GetPercent_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x0007E208 File Offset: 0x0007C408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883869, XrefRangeEnd = 883874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadAsyncData.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x0007E254 File Offset: 0x0007C454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883874, XrefRangeEnd = 883889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadAsyncData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x0007E298 File Offset: 0x0007C498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883889, XrefRangeEnd = 883893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RequestFinished(IAsyncData data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncData.NativeMethodInfoPtr_RequestFinished_Private_Static_Boolean_IAsyncData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x0000B767 File Offset: 0x00009967
		public LoadAsyncData(params IAsyncData[] datas)
			: this(new Il2CppReferenceArray<IAsyncData>(datas))
		{
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x0000B775 File Offset: 0x00009975
		public LoadAsyncData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06001AA7 RID: 6823 RVA: 0x0007E2DC File Offset: 0x0007C4DC
		// (set) Token: 0x06001AA8 RID: 6824 RVA: 0x0000B77E File Offset: 0x0000997E
		public unsafe int Total
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncData.NativeFieldInfoPtr_Total);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncData.NativeFieldInfoPtr_Total)) = value;
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06001AA9 RID: 6825 RVA: 0x0007E304 File Offset: 0x0007C504
		// (set) Token: 0x06001AAA RID: 6826 RVA: 0x0000B799 File Offset: 0x00009999
		public unsafe HashSet<IAsyncData> uninitializedDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncData.NativeFieldInfoPtr_uninitializedDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<IAsyncData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncData.NativeFieldInfoPtr_uninitializedDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012AD RID: 4781
		private static readonly IntPtr NativeFieldInfoPtr_Total;

		// Token: 0x040012AE RID: 4782
		private static readonly IntPtr NativeFieldInfoPtr_uninitializedDatas;

		// Token: 0x040012AF RID: 4783
		private static readonly IntPtr NativeMethodInfoPtr_get_PendingData_Public_get_ICollection_1_IAsyncData_0;

		// Token: 0x040012B0 RID: 4784
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_IAsyncData_0;

		// Token: 0x040012B1 RID: 4785
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IAsyncData_0;

		// Token: 0x040012B2 RID: 4786
		private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_get_Int32_0;

		// Token: 0x040012B3 RID: 4787
		private static readonly IntPtr NativeMethodInfoPtr_GetPercent_Public_Virtual_Final_New_Single_0;

		// Token: 0x040012B4 RID: 4788
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040012B5 RID: 4789
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040012B6 RID: 4790
		private static readonly IntPtr NativeMethodInfoPtr_RequestFinished_Private_Static_Boolean_IAsyncData_0;

		// Token: 0x0200037A RID: 890
		[ObfuscatedName("dwd.core.data.async.LoadAsyncData+<>O")]
		public static class __O : Object
		{
			// Token: 0x060027C5 RID: 10181 RVA: 0x00012062 File Offset: 0x00010262
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<LoadAsyncData.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadAsyncData>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadAsyncData.__O>.NativeClassPtr);
				LoadAsyncData.__O.NativeFieldInfoPtr__0___RequestFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAsyncData.__O>.NativeClassPtr, "<0>__RequestFinished");
			}

			// Token: 0x060027C6 RID: 10182 RVA: 0x00012096 File Offset: 0x00010296
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B3A RID: 2874
			// (get) Token: 0x060027C7 RID: 10183 RVA: 0x000A8A18 File Offset: 0x000A6C18
			// (set) Token: 0x060027C8 RID: 10184 RVA: 0x0001209F File Offset: 0x0001029F
			public unsafe static Predicate<IAsyncData> _0___RequestFinished
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadAsyncData.__O.NativeFieldInfoPtr__0___RequestFinished, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<IAsyncData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadAsyncData.__O.NativeFieldInfoPtr__0___RequestFinished, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B05 RID: 6917
			private static readonly IntPtr NativeFieldInfoPtr__0___RequestFinished;
		}

		// Token: 0x0200037B RID: 891
		[ObfuscatedName("dwd.core.data.async.LoadAsyncData+<execute>d__9")]
		public sealed class _execute_d__9 : Object
		{
			// Token: 0x060027C9 RID: 10185 RVA: 0x000A8A40 File Offset: 0x000A6C40
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__9()
			{
				Il2CppClassPointerStore<LoadAsyncData._execute_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadAsyncData>.NativeClassPtr, "<execute>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadAsyncData._execute_d__9>.NativeClassPtr);
				LoadAsyncData._execute_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAsyncData._execute_d__9>.NativeClassPtr, "<>1__state");
				LoadAsyncData._execute_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAsyncData._execute_d__9>.NativeClassPtr, "<>2__current");
				LoadAsyncData._execute_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAsyncData._execute_d__9>.NativeClassPtr, "<>4__this");
				LoadAsyncData._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncData._execute_d__9>.NativeClassPtr, 100667525);
				LoadAsyncData._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncData._execute_d__9>.NativeClassPtr, 100667526);
				LoadAsyncData._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncData._execute_d__9>.NativeClassPtr, 100667527);
				LoadAsyncData._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncData._execute_d__9>.NativeClassPtr, 100667528);
				LoadAsyncData._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncData._execute_d__9>.NativeClassPtr, 100667529);
				LoadAsyncData._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncData._execute_d__9>.NativeClassPtr, 100667530);
			}

			// Token: 0x060027CA RID: 10186 RVA: 0x000A8B20 File Offset: 0x000A6D20
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadAsyncData._execute_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncData._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060027CB RID: 10187 RVA: 0x000A8B68 File Offset: 0x000A6D68
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncData._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060027CC RID: 10188 RVA: 0x000A8B9C File Offset: 0x000A6D9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883797, XrefRangeEnd = 883843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncData._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B3E RID: 2878
			// (get) Token: 0x060027CD RID: 10189 RVA: 0x000A8BD8 File Offset: 0x000A6DD8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncData._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060027CE RID: 10190 RVA: 0x000A8C18 File Offset: 0x000A6E18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883843, XrefRangeEnd = 883848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncData._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B3F RID: 2879
			// (get) Token: 0x060027CF RID: 10191 RVA: 0x000A8C4C File Offset: 0x000A6E4C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncData._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060027D0 RID: 10192 RVA: 0x000120B1 File Offset: 0x000102B1
			public _execute_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B3B RID: 2875
			// (get) Token: 0x060027D1 RID: 10193 RVA: 0x000A8C8C File Offset: 0x000A6E8C
			// (set) Token: 0x060027D2 RID: 10194 RVA: 0x000120BA File Offset: 0x000102BA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncData._execute_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncData._execute_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B3C RID: 2876
			// (get) Token: 0x060027D3 RID: 10195 RVA: 0x000A8CB4 File Offset: 0x000A6EB4
			// (set) Token: 0x060027D4 RID: 10196 RVA: 0x000120D5 File Offset: 0x000102D5
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncData._execute_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncData._execute_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B3D RID: 2877
			// (get) Token: 0x060027D5 RID: 10197 RVA: 0x000A8CE4 File Offset: 0x000A6EE4
			// (set) Token: 0x060027D6 RID: 10198 RVA: 0x000120F4 File Offset: 0x000102F4
			public unsafe LoadAsyncData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncData._execute_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadAsyncData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncData._execute_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B06 RID: 6918
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B07 RID: 6919
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001B08 RID: 6920
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B09 RID: 6921
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001B0A RID: 6922
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B0B RID: 6923
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001B0C RID: 6924
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001B0D RID: 6925
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B0E RID: 6926
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
