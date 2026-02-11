using System;
using dwd.core;
using dwd.core.commands;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.canis.dbg_client.switchboard
{
	// Token: 0x0200006B RID: 107
	public class GetSwitchboardFeatureCommand : Command
	{
		// Token: 0x06000400 RID: 1024 RVA: 0x0002A1A8 File Offset: 0x000283A8
		// Note: this type is marked as 'beforefieldinit'.
		static GetSwitchboardFeatureCommand()
		{
			Il2CppClassPointerStore<GetSwitchboardFeatureCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.dbg_client.switchboard", "GetSwitchboardFeatureCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetSwitchboardFeatureCommand>.NativeClassPtr);
			GetSwitchboardFeatureCommand.NativeFieldInfoPtr_feature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSwitchboardFeatureCommand>.NativeClassPtr, "feature");
			GetSwitchboardFeatureCommand.NativeFieldInfoPtr_prefKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSwitchboardFeatureCommand>.NativeClassPtr, "prefKey");
			GetSwitchboardFeatureCommand.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSwitchboardFeatureCommand>.NativeClassPtr, "<Result>k__BackingField");
			GetSwitchboardFeatureCommand.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSwitchboardFeatureCommand>.NativeClassPtr, 100663907);
			GetSwitchboardFeatureCommand.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSwitchboardFeatureCommand>.NativeClassPtr, 100663908);
			GetSwitchboardFeatureCommand.NativeMethodInfoPtr_get_Result_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSwitchboardFeatureCommand>.NativeClassPtr, 100663909);
			GetSwitchboardFeatureCommand.NativeMethodInfoPtr_set_Result_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSwitchboardFeatureCommand>.NativeClassPtr, 100663910);
			GetSwitchboardFeatureCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSwitchboardFeatureCommand>.NativeClassPtr, 100663911);
			GetSwitchboardFeatureCommand.NativeMethodInfoPtr_handleResponse_Private_Void_DwdWebRequestCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSwitchboardFeatureCommand>.NativeClassPtr, 100663912);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0002A28C File Offset: 0x0002848C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 500243, RefRangeEnd = 500246, XrefRangeStart = 500237, XrefRangeEnd = 500243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetSwitchboardFeatureCommand(string feature)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetSwitchboardFeatureCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(feature);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSwitchboardFeatureCommand.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0002A2D8 File Offset: 0x000284D8
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 495165, RefRangeEnd = 495182, XrefRangeStart = 495165, XrefRangeEnd = 495182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetSwitchboardFeatureCommand(string feature, string prefKey)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetSwitchboardFeatureCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(feature);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSwitchboardFeatureCommand.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x0002A338 File Offset: 0x00028538
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x0002A374 File Offset: 0x00028574
		public unsafe bool Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSwitchboardFeatureCommand.NativeMethodInfoPtr_get_Result_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSwitchboardFeatureCommand.NativeMethodInfoPtr_set_Result_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0002A3B4 File Offset: 0x000285B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500246, XrefRangeEnd = 500316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetSwitchboardFeatureCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0002A400 File Offset: 0x00028600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500316, XrefRangeEnd = 500338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleResponse(DwdWebRequestCommand request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSwitchboardFeatureCommand.NativeMethodInfoPtr_handleResponse_Private_Void_DwdWebRequestCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00003C86 File Offset: 0x00001E86
		public GetSwitchboardFeatureCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x0002A444 File Offset: 0x00028644
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x00003C8F File Offset: 0x00001E8F
		public unsafe string feature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSwitchboardFeatureCommand.NativeFieldInfoPtr_feature);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSwitchboardFeatureCommand.NativeFieldInfoPtr_feature), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x0002A46C File Offset: 0x0002866C
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x00003CAE File Offset: 0x00001EAE
		public unsafe string prefKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSwitchboardFeatureCommand.NativeFieldInfoPtr_prefKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSwitchboardFeatureCommand.NativeFieldInfoPtr_prefKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x0002A494 File Offset: 0x00028694
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00003CCD File Offset: 0x00001ECD
		public unsafe bool _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSwitchboardFeatureCommand.NativeFieldInfoPtr__Result_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSwitchboardFeatureCommand.NativeFieldInfoPtr__Result_k__BackingField)) = value;
			}
		}

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeFieldInfoPtr_feature;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeFieldInfoPtr_prefKey;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_Boolean_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_Boolean_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_handleResponse_Private_Void_DwdWebRequestCommand_0;

		// Token: 0x020002EF RID: 751
		[ObfuscatedName("dwd.canis.dbg_client.switchboard.GetSwitchboardFeatureCommand+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06002378 RID: 9080 RVA: 0x00092970 File Offset: 0x00090B70
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<GetSwitchboardFeatureCommand.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetSwitchboardFeatureCommand>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetSwitchboardFeatureCommand.__c__DisplayClass8_0>.NativeClassPtr);
				GetSwitchboardFeatureCommand.__c__DisplayClass8_0.NativeFieldInfoPtr_baseUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSwitchboardFeatureCommand.__c__DisplayClass8_0>.NativeClassPtr, "baseUrl");
				GetSwitchboardFeatureCommand.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSwitchboardFeatureCommand.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				GetSwitchboardFeatureCommand.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSwitchboardFeatureCommand.__c__DisplayClass8_0>.NativeClassPtr, 100663913);
				GetSwitchboardFeatureCommand.__c__DisplayClass8_0.NativeMethodInfoPtr__execute_b__0_Internal_IFailable_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSwitchboardFeatureCommand.__c__DisplayClass8_0>.NativeClassPtr, 100663914);
				GetSwitchboardFeatureCommand.__c__DisplayClass8_0.NativeMethodInfoPtr__execute_b__1_Internal_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSwitchboardFeatureCommand.__c__DisplayClass8_0>.NativeClassPtr, 100663915);
			}

			// Token: 0x06002379 RID: 9081 RVA: 0x00092A00 File Offset: 0x00090C00
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetSwitchboardFeatureCommand.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSwitchboardFeatureCommand.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600237A RID: 9082 RVA: 0x00092A3C File Offset: 0x00090C3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500215, XrefRangeEnd = 500231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _execute_b__0(ErrorInfo _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSwitchboardFeatureCommand.__c__DisplayClass8_0.NativeMethodInfoPtr__execute_b__0_Internal_IFailable_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
				}
			}

			// Token: 0x0600237B RID: 9083 RVA: 0x00092A94 File Offset: 0x00090C94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500231, XrefRangeEnd = 500237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__1(ErrorInfo _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSwitchboardFeatureCommand.__c__DisplayClass8_0.NativeMethodInfoPtr__execute_b__1_Internal_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600237C RID: 9084 RVA: 0x0001279C File Offset: 0x0001099C
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009A2 RID: 2466
			// (get) Token: 0x0600237D RID: 9085 RVA: 0x00092ADC File Offset: 0x00090CDC
			// (set) Token: 0x0600237E RID: 9086 RVA: 0x000127A5 File Offset: 0x000109A5
			public unsafe string baseUrl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSwitchboardFeatureCommand.__c__DisplayClass8_0.NativeFieldInfoPtr_baseUrl);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSwitchboardFeatureCommand.__c__DisplayClass8_0.NativeFieldInfoPtr_baseUrl), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009A3 RID: 2467
			// (get) Token: 0x0600237F RID: 9087 RVA: 0x00092B04 File Offset: 0x00090D04
			// (set) Token: 0x06002380 RID: 9088 RVA: 0x000127C4 File Offset: 0x000109C4
			public unsafe GetSwitchboardFeatureCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSwitchboardFeatureCommand.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetSwitchboardFeatureCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSwitchboardFeatureCommand.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400164D RID: 5709
			private static readonly IntPtr NativeFieldInfoPtr_baseUrl;

			// Token: 0x0400164E RID: 5710
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400164F RID: 5711
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001650 RID: 5712
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_IFailable_ErrorInfo_0;

			// Token: 0x04001651 RID: 5713
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__1_Internal_Void_ErrorInfo_0;
		}
	}
}
