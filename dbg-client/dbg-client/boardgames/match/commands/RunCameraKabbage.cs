using System;
using boardgames.camera;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using voodoo.kabbage;

namespace boardgames.match.commands
{
	// Token: 0x02000293 RID: 659
	public class RunCameraKabbage : Command
	{
		// Token: 0x06001EF8 RID: 7928 RVA: 0x00084EFC File Offset: 0x000830FC
		// Note: this type is marked as 'beforefieldinit'.
		static RunCameraKabbage()
		{
			Il2CppClassPointerStore<RunCameraKabbage>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.commands", "RunCameraKabbage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunCameraKabbage>.NativeClassPtr);
			RunCameraKabbage.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCameraKabbage>.NativeClassPtr, "destination");
			RunCameraKabbage.NativeFieldInfoPtr_flavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCameraKabbage>.NativeClassPtr, "flavor");
			RunCameraKabbage.NativeFieldInfoPtr_poolManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCameraKabbage>.NativeClassPtr, "poolManager");
			RunCameraKabbage.NativeFieldInfoPtr_myKabbage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCameraKabbage>.NativeClassPtr, "myKabbage");
			RunCameraKabbage.NativeFieldInfoPtr_unitPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCameraKabbage>.NativeClassPtr, "unitPosition");
			RunCameraKabbage.NativeFieldInfoPtr_cameraView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCameraKabbage>.NativeClassPtr, "cameraView");
			RunCameraKabbage.NativeFieldInfoPtr_completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCameraKabbage>.NativeClassPtr, "completed");
			RunCameraKabbage.NativeFieldInfoPtr_ignoreAutoRestrictions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCameraKabbage>.NativeClassPtr, "ignoreAutoRestrictions");
			RunCameraKabbage.NativeFieldInfoPtr__Interrupted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCameraKabbage>.NativeClassPtr, "<Interrupted>k__BackingField");
			RunCameraKabbage.NativeMethodInfoPtr__ctor_Public_Void_GlobalTransform_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCameraKabbage>.NativeClassPtr, 100668465);
			RunCameraKabbage.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCameraKabbage>.NativeClassPtr, 100668466);
			RunCameraKabbage.NativeMethodInfoPtr_complete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCameraKabbage>.NativeClassPtr, 100668467);
			RunCameraKabbage.NativeMethodInfoPtr_Interrupt_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCameraKabbage>.NativeClassPtr, 100668468);
			RunCameraKabbage.NativeMethodInfoPtr_get_Interrupted_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCameraKabbage>.NativeClassPtr, 100668469);
			RunCameraKabbage.NativeMethodInfoPtr_set_Interrupted_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCameraKabbage>.NativeClassPtr, 100668470);
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x00085058 File Offset: 0x00083258
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 540710, RefRangeEnd = 540713, XrefRangeStart = 540705, XrefRangeEnd = 540710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunCameraKabbage(GlobalTransform destination, string flavor = null, bool ignoreAutoRestrictions = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunCameraKabbage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref destination;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(flavor);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreAutoRestrictions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCameraKabbage.NativeMethodInfoPtr__ctor_Public_Void_GlobalTransform_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x000850C0 File Offset: 0x000832C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540713, XrefRangeEnd = 540718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunCameraKabbage.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x0008510C File Offset: 0x0008330C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540718, XrefRangeEnd = 540731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void complete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCameraKabbage.NativeMethodInfoPtr_complete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x00085140 File Offset: 0x00083340
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 540747, RefRangeEnd = 540748, XrefRangeStart = 540731, XrefRangeEnd = 540747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCameraKabbage.NativeMethodInfoPtr_Interrupt_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001EFD RID: 7933 RVA: 0x00085174 File Offset: 0x00083374
		// (set) Token: 0x06001EFE RID: 7934 RVA: 0x000851B0 File Offset: 0x000833B0
		public unsafe virtual bool Interrupted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCameraKabbage.NativeMethodInfoPtr_get_Interrupted_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCameraKabbage.NativeMethodInfoPtr_set_Interrupted_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x00010473 File Offset: 0x0000E673
		public RunCameraKabbage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001F00 RID: 7936 RVA: 0x000851F0 File Offset: 0x000833F0
		// (set) Token: 0x06001F01 RID: 7937 RVA: 0x0001047C File Offset: 0x0000E67C
		public unsafe GlobalTransform destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage.NativeFieldInfoPtr_destination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage.NativeFieldInfoPtr_destination)) = value;
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001F02 RID: 7938 RVA: 0x00085218 File Offset: 0x00083418
		// (set) Token: 0x06001F03 RID: 7939 RVA: 0x00010497 File Offset: 0x0000E697
		public unsafe string flavor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage.NativeFieldInfoPtr_flavor);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage.NativeFieldInfoPtr_flavor), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001F04 RID: 7940 RVA: 0x00085240 File Offset: 0x00083440
		// (set) Token: 0x06001F05 RID: 7941 RVA: 0x000104B6 File Offset: 0x0000E6B6
		public unsafe PoolManager poolManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage.NativeFieldInfoPtr_poolManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage.NativeFieldInfoPtr_poolManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001F06 RID: 7942 RVA: 0x00085270 File Offset: 0x00083470
		// (set) Token: 0x06001F07 RID: 7943 RVA: 0x000104D5 File Offset: 0x0000E6D5
		public unsafe VoodooRenderAnimator myKabbage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage.NativeFieldInfoPtr_myKabbage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooRenderAnimator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage.NativeFieldInfoPtr_myKabbage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001F08 RID: 7944 RVA: 0x000852A0 File Offset: 0x000834A0
		// (set) Token: 0x06001F09 RID: 7945 RVA: 0x000104F4 File Offset: 0x0000E6F4
		public unsafe UnitPosition unitPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage.NativeFieldInfoPtr_unitPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitPosition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage.NativeFieldInfoPtr_unitPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001F0A RID: 7946 RVA: 0x000852D0 File Offset: 0x000834D0
		// (set) Token: 0x06001F0B RID: 7947 RVA: 0x00010513 File Offset: 0x0000E713
		public unsafe UnitView cameraView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage.NativeFieldInfoPtr_cameraView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage.NativeFieldInfoPtr_cameraView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x00085300 File Offset: 0x00083500
		// (set) Token: 0x06001F0D RID: 7949 RVA: 0x00010532 File Offset: 0x0000E732
		public unsafe bool completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage.NativeFieldInfoPtr_completed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage.NativeFieldInfoPtr_completed)) = value;
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001F0E RID: 7950 RVA: 0x00085328 File Offset: 0x00083528
		// (set) Token: 0x06001F0F RID: 7951 RVA: 0x0001054D File Offset: 0x0000E74D
		public unsafe bool ignoreAutoRestrictions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage.NativeFieldInfoPtr_ignoreAutoRestrictions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage.NativeFieldInfoPtr_ignoreAutoRestrictions)) = value;
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001F10 RID: 7952 RVA: 0x00085350 File Offset: 0x00083550
		// (set) Token: 0x06001F11 RID: 7953 RVA: 0x00010568 File Offset: 0x0000E768
		public unsafe bool _Interrupted_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage.NativeFieldInfoPtr__Interrupted_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage.NativeFieldInfoPtr__Interrupted_k__BackingField)) = value;
			}
		}

		// Token: 0x04001393 RID: 5011
		private static readonly IntPtr NativeFieldInfoPtr_destination;

		// Token: 0x04001394 RID: 5012
		private static readonly IntPtr NativeFieldInfoPtr_flavor;

		// Token: 0x04001395 RID: 5013
		private static readonly IntPtr NativeFieldInfoPtr_poolManager;

		// Token: 0x04001396 RID: 5014
		private static readonly IntPtr NativeFieldInfoPtr_myKabbage;

		// Token: 0x04001397 RID: 5015
		private static readonly IntPtr NativeFieldInfoPtr_unitPosition;

		// Token: 0x04001398 RID: 5016
		private static readonly IntPtr NativeFieldInfoPtr_cameraView;

		// Token: 0x04001399 RID: 5017
		private static readonly IntPtr NativeFieldInfoPtr_completed;

		// Token: 0x0400139A RID: 5018
		private static readonly IntPtr NativeFieldInfoPtr_ignoreAutoRestrictions;

		// Token: 0x0400139B RID: 5019
		private static readonly IntPtr NativeFieldInfoPtr__Interrupted_k__BackingField;

		// Token: 0x0400139C RID: 5020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GlobalTransform_String_Boolean_0;

		// Token: 0x0400139D RID: 5021
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0400139E RID: 5022
		private static readonly IntPtr NativeMethodInfoPtr_complete_Private_Void_0;

		// Token: 0x0400139F RID: 5023
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Virtual_Final_New_Void_0;

		// Token: 0x040013A0 RID: 5024
		private static readonly IntPtr NativeMethodInfoPtr_get_Interrupted_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040013A1 RID: 5025
		private static readonly IntPtr NativeMethodInfoPtr_set_Interrupted_Private_set_Void_Boolean_0;

		// Token: 0x02000490 RID: 1168
		[ObfuscatedName("boardgames.match.commands.RunCameraKabbage+<execute>d__9")]
		public sealed class _execute_d__9 : Object
		{
			// Token: 0x0600375A RID: 14170 RVA: 0x000CDE4C File Offset: 0x000CC04C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__9()
			{
				Il2CppClassPointerStore<RunCameraKabbage._execute_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunCameraKabbage>.NativeClassPtr, "<execute>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunCameraKabbage._execute_d__9>.NativeClassPtr);
				RunCameraKabbage._execute_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCameraKabbage._execute_d__9>.NativeClassPtr, "<>1__state");
				RunCameraKabbage._execute_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCameraKabbage._execute_d__9>.NativeClassPtr, "<>2__current");
				RunCameraKabbage._execute_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCameraKabbage._execute_d__9>.NativeClassPtr, "<>4__this");
				RunCameraKabbage._execute_d__9.NativeFieldInfoPtr__cameraControlProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCameraKabbage._execute_d__9>.NativeClassPtr, "<cameraControlProvider>5__2");
				RunCameraKabbage._execute_d__9.NativeFieldInfoPtr__destLocal_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCameraKabbage._execute_d__9>.NativeClassPtr, "<destLocal>5__3");
				RunCameraKabbage._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCameraKabbage._execute_d__9>.NativeClassPtr, 100668471);
				RunCameraKabbage._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCameraKabbage._execute_d__9>.NativeClassPtr, 100668472);
				RunCameraKabbage._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCameraKabbage._execute_d__9>.NativeClassPtr, 100668473);
				RunCameraKabbage._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCameraKabbage._execute_d__9>.NativeClassPtr, 100668474);
				RunCameraKabbage._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCameraKabbage._execute_d__9>.NativeClassPtr, 100668475);
				RunCameraKabbage._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCameraKabbage._execute_d__9>.NativeClassPtr, 100668476);
			}

			// Token: 0x0600375B RID: 14171 RVA: 0x000CDF54 File Offset: 0x000CC154
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunCameraKabbage._execute_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCameraKabbage._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600375C RID: 14172 RVA: 0x000CDF9C File Offset: 0x000CC19C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCameraKabbage._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600375D RID: 14173 RVA: 0x000CDFD0 File Offset: 0x000CC1D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540596, XrefRangeEnd = 540700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCameraKabbage._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001054 RID: 4180
			// (get) Token: 0x0600375E RID: 14174 RVA: 0x000CE00C File Offset: 0x000CC20C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCameraKabbage._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600375F RID: 14175 RVA: 0x000CE04C File Offset: 0x000CC24C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540700, XrefRangeEnd = 540705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCameraKabbage._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001055 RID: 4181
			// (get) Token: 0x06003760 RID: 14176 RVA: 0x000CE080 File Offset: 0x000CC280
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCameraKabbage._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003761 RID: 14177 RVA: 0x0001C75B File Offset: 0x0001A95B
			public _execute_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700104F RID: 4175
			// (get) Token: 0x06003762 RID: 14178 RVA: 0x000CE0C0 File Offset: 0x000CC2C0
			// (set) Token: 0x06003763 RID: 14179 RVA: 0x0001C764 File Offset: 0x0001A964
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage._execute_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage._execute_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001050 RID: 4176
			// (get) Token: 0x06003764 RID: 14180 RVA: 0x000CE0E8 File Offset: 0x000CC2E8
			// (set) Token: 0x06003765 RID: 14181 RVA: 0x0001C77F File Offset: 0x0001A97F
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage._execute_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage._execute_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001051 RID: 4177
			// (get) Token: 0x06003766 RID: 14182 RVA: 0x000CE118 File Offset: 0x000CC318
			// (set) Token: 0x06003767 RID: 14183 RVA: 0x0001C79E File Offset: 0x0001A99E
			public unsafe RunCameraKabbage __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage._execute_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunCameraKabbage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage._execute_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001052 RID: 4178
			// (get) Token: 0x06003768 RID: 14184 RVA: 0x000CE148 File Offset: 0x000CC348
			// (set) Token: 0x06003769 RID: 14185 RVA: 0x0001C7BD File Offset: 0x0001A9BD
			public unsafe CameraControlProvider _cameraControlProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage._execute_d__9.NativeFieldInfoPtr__cameraControlProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraControlProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage._execute_d__9.NativeFieldInfoPtr__cameraControlProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001053 RID: 4179
			// (get) Token: 0x0600376A RID: 14186 RVA: 0x000CE178 File Offset: 0x000CC378
			// (set) Token: 0x0600376B RID: 14187 RVA: 0x0001C7DC File Offset: 0x0001A9DC
			public unsafe LocalTransform _destLocal_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage._execute_d__9.NativeFieldInfoPtr__destLocal_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCameraKabbage._execute_d__9.NativeFieldInfoPtr__destLocal_5__3)) = value;
				}
			}

			// Token: 0x0400220E RID: 8718
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400220F RID: 8719
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002210 RID: 8720
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002211 RID: 8721
			private static readonly IntPtr NativeFieldInfoPtr__cameraControlProvider_5__2;

			// Token: 0x04002212 RID: 8722
			private static readonly IntPtr NativeFieldInfoPtr__destLocal_5__3;

			// Token: 0x04002213 RID: 8723
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002214 RID: 8724
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002215 RID: 8725
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002216 RID: 8726
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002217 RID: 8727
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002218 RID: 8728
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
