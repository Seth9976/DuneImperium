using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.commands
{
	// Token: 0x020001E9 RID: 489
	public class FreeMemoryCommand : Command
	{
		// Token: 0x06001AAB RID: 6827 RVA: 0x0007E334 File Offset: 0x0007C534
		// Note: this type is marked as 'beforefieldinit'.
		static FreeMemoryCommand()
		{
			Il2CppClassPointerStore<FreeMemoryCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.commands", "FreeMemoryCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreeMemoryCommand>.NativeClassPtr);
			FreeMemoryCommand.NativeFieldInfoPtr_freeMemoryOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeMemoryCommand>.NativeClassPtr, "freeMemoryOptions");
			FreeMemoryCommand.NativeMethodInfoPtr__ctor_Public_Void_FreeMemoryOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeMemoryCommand>.NativeClassPtr, 100667531);
			FreeMemoryCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeMemoryCommand>.NativeClassPtr, 100667532);
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x0007E3A0 File Offset: 0x0007C5A0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 505412, RefRangeEnd = 505418, XrefRangeStart = 505412, XrefRangeEnd = 505418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FreeMemoryCommand(FreeMemoryCommand.FreeMemoryOptions freeMemoryOptions = FreeMemoryCommand.FreeMemoryOptions.UnloadUnusedResources)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreeMemoryCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref freeMemoryOptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeMemoryCommand.NativeMethodInfoPtr__ctor_Public_Void_FreeMemoryOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x0007E3E8 File Offset: 0x0007C5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883922, XrefRangeEnd = 883927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FreeMemoryCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x0000B7B8 File Offset: 0x000099B8
		public FreeMemoryCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06001AAF RID: 6831 RVA: 0x0007E434 File Offset: 0x0007C634
		// (set) Token: 0x06001AB0 RID: 6832 RVA: 0x0000B7C1 File Offset: 0x000099C1
		public unsafe FreeMemoryCommand.FreeMemoryOptions freeMemoryOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeMemoryCommand.NativeFieldInfoPtr_freeMemoryOptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeMemoryCommand.NativeFieldInfoPtr_freeMemoryOptions)) = value;
			}
		}

		// Token: 0x040012B7 RID: 4791
		private static readonly IntPtr NativeFieldInfoPtr_freeMemoryOptions;

		// Token: 0x040012B8 RID: 4792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FreeMemoryOptions_0;

		// Token: 0x040012B9 RID: 4793
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0200037C RID: 892
		[Flags]
		public enum FreeMemoryOptions
		{
			// Token: 0x04001B10 RID: 6928
			None = 0,
			// Token: 0x04001B11 RID: 6929
			UnloadUnusedResources = 1,
			// Token: 0x04001B12 RID: 6930
			GarbageCollect = 2
		}

		// Token: 0x0200037D RID: 893
		[ObfuscatedName("dwd.core.commands.FreeMemoryCommand+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x060027D7 RID: 10199 RVA: 0x000A8D14 File Offset: 0x000A6F14
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<FreeMemoryCommand._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FreeMemoryCommand>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreeMemoryCommand._execute_d__3>.NativeClassPtr);
				FreeMemoryCommand._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeMemoryCommand._execute_d__3>.NativeClassPtr, "<>1__state");
				FreeMemoryCommand._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeMemoryCommand._execute_d__3>.NativeClassPtr, "<>2__current");
				FreeMemoryCommand._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeMemoryCommand._execute_d__3>.NativeClassPtr, "<>4__this");
				FreeMemoryCommand._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeMemoryCommand._execute_d__3>.NativeClassPtr, 100667533);
				FreeMemoryCommand._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeMemoryCommand._execute_d__3>.NativeClassPtr, 100667534);
				FreeMemoryCommand._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeMemoryCommand._execute_d__3>.NativeClassPtr, 100667535);
				FreeMemoryCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeMemoryCommand._execute_d__3>.NativeClassPtr, 100667536);
				FreeMemoryCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeMemoryCommand._execute_d__3>.NativeClassPtr, 100667537);
				FreeMemoryCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeMemoryCommand._execute_d__3>.NativeClassPtr, 100667538);
			}

			// Token: 0x060027D8 RID: 10200 RVA: 0x000A8DF4 File Offset: 0x000A6FF4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreeMemoryCommand._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeMemoryCommand._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060027D9 RID: 10201 RVA: 0x000A8E3C File Offset: 0x000A703C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeMemoryCommand._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060027DA RID: 10202 RVA: 0x000A8E70 File Offset: 0x000A7070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883893, XrefRangeEnd = 883917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeMemoryCommand._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B43 RID: 2883
			// (get) Token: 0x060027DB RID: 10203 RVA: 0x000A8EAC File Offset: 0x000A70AC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeMemoryCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060027DC RID: 10204 RVA: 0x000A8EEC File Offset: 0x000A70EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883917, XrefRangeEnd = 883922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeMemoryCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B44 RID: 2884
			// (get) Token: 0x060027DD RID: 10205 RVA: 0x000A8F20 File Offset: 0x000A7120
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeMemoryCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060027DE RID: 10206 RVA: 0x00012113 File Offset: 0x00010313
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B40 RID: 2880
			// (get) Token: 0x060027DF RID: 10207 RVA: 0x000A8F60 File Offset: 0x000A7160
			// (set) Token: 0x060027E0 RID: 10208 RVA: 0x0001211C File Offset: 0x0001031C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeMemoryCommand._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeMemoryCommand._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B41 RID: 2881
			// (get) Token: 0x060027E1 RID: 10209 RVA: 0x000A8F88 File Offset: 0x000A7188
			// (set) Token: 0x060027E2 RID: 10210 RVA: 0x00012137 File Offset: 0x00010337
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeMemoryCommand._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeMemoryCommand._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B42 RID: 2882
			// (get) Token: 0x060027E3 RID: 10211 RVA: 0x000A8FB8 File Offset: 0x000A71B8
			// (set) Token: 0x060027E4 RID: 10212 RVA: 0x00012156 File Offset: 0x00010356
			public unsafe FreeMemoryCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeMemoryCommand._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FreeMemoryCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeMemoryCommand._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B13 RID: 6931
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B14 RID: 6932
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001B15 RID: 6933
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B16 RID: 6934
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001B17 RID: 6935
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B18 RID: 6936
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001B19 RID: 6937
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001B1A RID: 6938
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B1B RID: 6939
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
