using System;
using dwd.core.commands;
using dwd.core.networking.commands;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Networking;

namespace boardgames.menus.commands
{
	// Token: 0x02000226 RID: 550
	public class RunDeleteAccountFlow : Command
	{
		// Token: 0x06001920 RID: 6432 RVA: 0x0006F354 File Offset: 0x0006D554
		// Note: this type is marked as 'beforefieldinit'.
		static RunDeleteAccountFlow()
		{
			Il2CppClassPointerStore<RunDeleteAccountFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunDeleteAccountFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunDeleteAccountFlow>.NativeClassPtr);
			RunDeleteAccountFlow.NativeFieldInfoPtr__Deleted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeleteAccountFlow>.NativeClassPtr, "<Deleted>k__BackingField");
			RunDeleteAccountFlow.NativeMethodInfoPtr_get_Deleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeleteAccountFlow>.NativeClassPtr, 100667139);
			RunDeleteAccountFlow.NativeMethodInfoPtr_set_Deleted_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeleteAccountFlow>.NativeClassPtr, 100667140);
			RunDeleteAccountFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeleteAccountFlow>.NativeClassPtr, 100667141);
			RunDeleteAccountFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeleteAccountFlow>.NativeClassPtr, 100667142);
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001921 RID: 6433 RVA: 0x0006F3E8 File Offset: 0x0006D5E8
		// (set) Token: 0x06001922 RID: 6434 RVA: 0x0006F424 File Offset: 0x0006D624
		public unsafe bool Deleted
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeleteAccountFlow.NativeMethodInfoPtr_get_Deleted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeleteAccountFlow.NativeMethodInfoPtr_set_Deleted_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x0006F464 File Offset: 0x0006D664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528665, XrefRangeEnd = 528670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunDeleteAccountFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x0006F4B0 File Offset: 0x0006D6B0
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunDeleteAccountFlow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunDeleteAccountFlow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeleteAccountFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x0000DDAB File Offset: 0x0000BFAB
		public RunDeleteAccountFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x0006F4EC File Offset: 0x0006D6EC
		// (set) Token: 0x06001927 RID: 6439 RVA: 0x0000DDB4 File Offset: 0x0000BFB4
		public unsafe bool _Deleted_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeleteAccountFlow.NativeFieldInfoPtr__Deleted_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeleteAccountFlow.NativeFieldInfoPtr__Deleted_k__BackingField)) = value;
			}
		}

		// Token: 0x04000FB2 RID: 4018
		private static readonly IntPtr NativeFieldInfoPtr__Deleted_k__BackingField;

		// Token: 0x04000FB3 RID: 4019
		private static readonly IntPtr NativeMethodInfoPtr_get_Deleted_Public_get_Boolean_0;

		// Token: 0x04000FB4 RID: 4020
		private static readonly IntPtr NativeMethodInfoPtr_set_Deleted_Private_set_Void_Boolean_0;

		// Token: 0x04000FB5 RID: 4021
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000FB6 RID: 4022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000405 RID: 1029
		[ObfuscatedName("boardgames.menus.commands.RunDeleteAccountFlow+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003065 RID: 12389 RVA: 0x000B8F84 File Offset: 0x000B7184
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RunDeleteAccountFlow.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunDeleteAccountFlow>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunDeleteAccountFlow.__c>.NativeClassPtr);
				RunDeleteAccountFlow.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeleteAccountFlow.__c>.NativeClassPtr, "<>9");
				RunDeleteAccountFlow.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeleteAccountFlow.__c>.NativeClassPtr, "<>9__4_0");
				RunDeleteAccountFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeleteAccountFlow.__c>.NativeClassPtr, 100667144);
				RunDeleteAccountFlow.__c.NativeMethodInfoPtr__execute_b__4_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeleteAccountFlow.__c>.NativeClassPtr, 100667145);
			}

			// Token: 0x06003066 RID: 12390 RVA: 0x000B9000 File Offset: 0x000B7200
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunDeleteAccountFlow.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeleteAccountFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003067 RID: 12391 RVA: 0x000B903C File Offset: 0x000B723C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528604, XrefRangeEnd = 528612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__4_0(UnityWebRequest request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeleteAccountFlow.__c.NativeMethodInfoPtr__execute_b__4_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003068 RID: 12392 RVA: 0x00019034 File Offset: 0x00017234
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DF5 RID: 3573
			// (get) Token: 0x06003069 RID: 12393 RVA: 0x000B9080 File Offset: 0x000B7280
			// (set) Token: 0x0600306A RID: 12394 RVA: 0x0001903D File Offset: 0x0001723D
			public unsafe static RunDeleteAccountFlow.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunDeleteAccountFlow.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunDeleteAccountFlow.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunDeleteAccountFlow.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DF6 RID: 3574
			// (get) Token: 0x0600306B RID: 12395 RVA: 0x000B90A8 File Offset: 0x000B72A8
			// (set) Token: 0x0600306C RID: 12396 RVA: 0x0001904F File Offset: 0x0001724F
			public unsafe static Action<UnityWebRequest> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunDeleteAccountFlow.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunDeleteAccountFlow.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001DEE RID: 7662
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001DEF RID: 7663
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04001DF0 RID: 7664
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001DF1 RID: 7665
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__4_0_Internal_Void_UnityWebRequest_0;
		}

		// Token: 0x02000406 RID: 1030
		[ObfuscatedName("boardgames.menus.commands.RunDeleteAccountFlow+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x0600306D RID: 12397 RVA: 0x000B90D0 File Offset: 0x000B72D0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<RunDeleteAccountFlow._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunDeleteAccountFlow>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunDeleteAccountFlow._execute_d__4>.NativeClassPtr);
				RunDeleteAccountFlow._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeleteAccountFlow._execute_d__4>.NativeClassPtr, "<>1__state");
				RunDeleteAccountFlow._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeleteAccountFlow._execute_d__4>.NativeClassPtr, "<>2__current");
				RunDeleteAccountFlow._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeleteAccountFlow._execute_d__4>.NativeClassPtr, "<>4__this");
				RunDeleteAccountFlow._execute_d__4.NativeFieldInfoPtr__confirmationPrompt_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeleteAccountFlow._execute_d__4>.NativeClassPtr, "<confirmationPrompt>5__2");
				RunDeleteAccountFlow._execute_d__4.NativeFieldInfoPtr__webRequest_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeleteAccountFlow._execute_d__4>.NativeClassPtr, "<webRequest>5__3");
				RunDeleteAccountFlow._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeleteAccountFlow._execute_d__4>.NativeClassPtr, 100667146);
				RunDeleteAccountFlow._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeleteAccountFlow._execute_d__4>.NativeClassPtr, 100667147);
				RunDeleteAccountFlow._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeleteAccountFlow._execute_d__4>.NativeClassPtr, 100667148);
				RunDeleteAccountFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeleteAccountFlow._execute_d__4>.NativeClassPtr, 100667149);
				RunDeleteAccountFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeleteAccountFlow._execute_d__4>.NativeClassPtr, 100667150);
				RunDeleteAccountFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeleteAccountFlow._execute_d__4>.NativeClassPtr, 100667151);
			}

			// Token: 0x0600306E RID: 12398 RVA: 0x000B91D8 File Offset: 0x000B73D8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunDeleteAccountFlow._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeleteAccountFlow._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600306F RID: 12399 RVA: 0x000B9220 File Offset: 0x000B7420
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeleteAccountFlow._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003070 RID: 12400 RVA: 0x000B9254 File Offset: 0x000B7454
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528612, XrefRangeEnd = 528660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeleteAccountFlow._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000DFC RID: 3580
			// (get) Token: 0x06003071 RID: 12401 RVA: 0x000B9290 File Offset: 0x000B7490
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeleteAccountFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003072 RID: 12402 RVA: 0x000B92D0 File Offset: 0x000B74D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528660, XrefRangeEnd = 528665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeleteAccountFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DFD RID: 3581
			// (get) Token: 0x06003073 RID: 12403 RVA: 0x000B9304 File Offset: 0x000B7504
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeleteAccountFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003074 RID: 12404 RVA: 0x00019061 File Offset: 0x00017261
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DF7 RID: 3575
			// (get) Token: 0x06003075 RID: 12405 RVA: 0x000B9344 File Offset: 0x000B7544
			// (set) Token: 0x06003076 RID: 12406 RVA: 0x0001906A File Offset: 0x0001726A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeleteAccountFlow._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeleteAccountFlow._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000DF8 RID: 3576
			// (get) Token: 0x06003077 RID: 12407 RVA: 0x000B936C File Offset: 0x000B756C
			// (set) Token: 0x06003078 RID: 12408 RVA: 0x00019085 File Offset: 0x00017285
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeleteAccountFlow._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeleteAccountFlow._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DF9 RID: 3577
			// (get) Token: 0x06003079 RID: 12409 RVA: 0x000B939C File Offset: 0x000B759C
			// (set) Token: 0x0600307A RID: 12410 RVA: 0x000190A4 File Offset: 0x000172A4
			public unsafe RunDeleteAccountFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeleteAccountFlow._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunDeleteAccountFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeleteAccountFlow._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DFA RID: 3578
			// (get) Token: 0x0600307B RID: 12411 RVA: 0x000B93CC File Offset: 0x000B75CC
			// (set) Token: 0x0600307C RID: 12412 RVA: 0x000190C3 File Offset: 0x000172C3
			public unsafe ConfirmOrDenyPrompt _confirmationPrompt_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeleteAccountFlow._execute_d__4.NativeFieldInfoPtr__confirmationPrompt_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeleteAccountFlow._execute_d__4.NativeFieldInfoPtr__confirmationPrompt_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DFB RID: 3579
			// (get) Token: 0x0600307D RID: 12413 RVA: 0x000B93FC File Offset: 0x000B75FC
			// (set) Token: 0x0600307E RID: 12414 RVA: 0x000190E2 File Offset: 0x000172E2
			public unsafe DwdWebRequestCommand _webRequest_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeleteAccountFlow._execute_d__4.NativeFieldInfoPtr__webRequest_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DwdWebRequestCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeleteAccountFlow._execute_d__4.NativeFieldInfoPtr__webRequest_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001DF2 RID: 7666
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001DF3 RID: 7667
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001DF4 RID: 7668
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001DF5 RID: 7669
			private static readonly IntPtr NativeFieldInfoPtr__confirmationPrompt_5__2;

			// Token: 0x04001DF6 RID: 7670
			private static readonly IntPtr NativeFieldInfoPtr__webRequest_5__3;

			// Token: 0x04001DF7 RID: 7671
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001DF8 RID: 7672
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DF9 RID: 7673
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001DFA RID: 7674
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001DFB RID: 7675
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DFC RID: 7676
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
