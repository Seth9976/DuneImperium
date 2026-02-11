using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Networking;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x02000034 RID: 52
	public class BinaryDataProvider : ResourceProviderBase
	{
		// Token: 0x060002D6 RID: 726 RVA: 0x0000FBEC File Offset: 0x0000DDEC
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryDataProvider()
		{
			Il2CppClassPointerStore<BinaryDataProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "BinaryDataProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryDataProvider>.NativeClassPtr);
			BinaryDataProvider.NativeFieldInfoPtr__IgnoreFailures_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryDataProvider>.NativeClassPtr, "<IgnoreFailures>k__BackingField");
			BinaryDataProvider.NativeMethodInfoPtr_get_IgnoreFailures_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryDataProvider>.NativeClassPtr, 100663748);
			BinaryDataProvider.NativeMethodInfoPtr_set_IgnoreFailures_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryDataProvider>.NativeClassPtr, 100663749);
			BinaryDataProvider.NativeMethodInfoPtr_Convert_Public_Virtual_New_Object_Type_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryDataProvider>.NativeClassPtr, 100663750);
			BinaryDataProvider.NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryDataProvider>.NativeClassPtr, 100663751);
			BinaryDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryDataProvider>.NativeClassPtr, 100663752);
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0000FC94 File Offset: 0x0000DE94
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x0000FCD0 File Offset: 0x0000DED0
		public unsafe bool IgnoreFailures
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryDataProvider.NativeMethodInfoPtr_get_IgnoreFailures_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryDataProvider.NativeMethodInfoPtr_set_IgnoreFailures_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000FD10 File Offset: 0x0000DF10
		[CallerCount(0)]
		public unsafe virtual Object Convert(Type type, Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryDataProvider.NativeMethodInfoPtr_Convert_Public_Virtual_New_Object_Type_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000FD80 File Offset: 0x0000DF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140094, XrefRangeEnd = 1140099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Provide(ProvideHandle provideHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(provideHandle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryDataProvider.NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000FDD4 File Offset: 0x0000DFD4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryDataProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryDataProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00003299 File Offset: 0x00001499
		public BinaryDataProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002DD RID: 733 RVA: 0x0000FE10 File Offset: 0x0000E010
		// (set) Token: 0x060002DE RID: 734 RVA: 0x000032A2 File Offset: 0x000014A2
		public unsafe bool _IgnoreFailures_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryDataProvider.NativeFieldInfoPtr__IgnoreFailures_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryDataProvider.NativeFieldInfoPtr__IgnoreFailures_k__BackingField)) = value;
			}
		}

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeFieldInfoPtr__IgnoreFailures_k__BackingField;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreFailures_Public_get_Boolean_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreFailures_Public_set_Void_Boolean_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_New_Object_Type_Il2CppStructArray_1_Byte_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000081 RID: 129
		public class InternalOp : Object
		{
			// Token: 0x06000642 RID: 1602 RVA: 0x0001DE70 File Offset: 0x0001C070
			// Note: this type is marked as 'beforefieldinit'.
			static InternalOp()
			{
				Il2CppClassPointerStore<BinaryDataProvider.InternalOp>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BinaryDataProvider>.NativeClassPtr, "InternalOp");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryDataProvider.InternalOp>.NativeClassPtr);
				BinaryDataProvider.InternalOp.NativeFieldInfoPtr_m_Provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryDataProvider.InternalOp>.NativeClassPtr, "m_Provider");
				BinaryDataProvider.InternalOp.NativeFieldInfoPtr_m_RequestOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryDataProvider.InternalOp>.NativeClassPtr, "m_RequestOperation");
				BinaryDataProvider.InternalOp.NativeFieldInfoPtr_m_RequestQueueOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryDataProvider.InternalOp>.NativeClassPtr, "m_RequestQueueOperation");
				BinaryDataProvider.InternalOp.NativeFieldInfoPtr_m_PI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryDataProvider.InternalOp>.NativeClassPtr, "m_PI");
				BinaryDataProvider.InternalOp.NativeFieldInfoPtr_m_IgnoreFailures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryDataProvider.InternalOp>.NativeClassPtr, "m_IgnoreFailures");
				BinaryDataProvider.InternalOp.NativeFieldInfoPtr_m_Complete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryDataProvider.InternalOp>.NativeClassPtr, "m_Complete");
				BinaryDataProvider.InternalOp.NativeFieldInfoPtr_m_Timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryDataProvider.InternalOp>.NativeClassPtr, "m_Timeout");
				BinaryDataProvider.InternalOp.NativeMethodInfoPtr_GetPercentComplete_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryDataProvider.InternalOp>.NativeClassPtr, 100663753);
				BinaryDataProvider.InternalOp.NativeMethodInfoPtr_Start_Public_Void_ProvideHandle_BinaryDataProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryDataProvider.InternalOp>.NativeClassPtr, 100663754);
				BinaryDataProvider.InternalOp.NativeMethodInfoPtr_WaitForCompletionHandler_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryDataProvider.InternalOp>.NativeClassPtr, 100663755);
				BinaryDataProvider.InternalOp.NativeMethodInfoPtr_RequestOperation_completed_Private_Void_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryDataProvider.InternalOp>.NativeClassPtr, 100663756);
				BinaryDataProvider.InternalOp.NativeMethodInfoPtr_CompleteOperation_Protected_Void_Il2CppStructArray_1_Byte_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryDataProvider.InternalOp>.NativeClassPtr, 100663757);
				BinaryDataProvider.InternalOp.NativeMethodInfoPtr_ConvertBytes_Private_Object_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryDataProvider.InternalOp>.NativeClassPtr, 100663758);
				BinaryDataProvider.InternalOp.NativeMethodInfoPtr_SendWebRequest_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryDataProvider.InternalOp>.NativeClassPtr, 100663759);
				BinaryDataProvider.InternalOp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryDataProvider.InternalOp>.NativeClassPtr, 100663760);
				BinaryDataProvider.InternalOp.NativeMethodInfoPtr__SendWebRequest_b__13_0_Private_Void_UnityWebRequestAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryDataProvider.InternalOp>.NativeClassPtr, 100663761);
			}

			// Token: 0x06000643 RID: 1603 RVA: 0x0001DFDC File Offset: 0x0001C1DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float GetPercentComplete()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryDataProvider.InternalOp.NativeMethodInfoPtr_GetPercentComplete_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000644 RID: 1604 RVA: 0x0001E018 File Offset: 0x0001C218
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1140002, RefRangeEnd = 1140003, XrefRangeStart = 1139952, XrefRangeEnd = 1140002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Start(ProvideHandle provideHandle, BinaryDataProvider rawProvider)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(provideHandle));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rawProvider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryDataProvider.InternalOp.NativeMethodInfoPtr_Start_Public_Void_ProvideHandle_BinaryDataProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000645 RID: 1605 RVA: 0x0001E074 File Offset: 0x0001C274
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140003, XrefRangeEnd = 1140005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool WaitForCompletionHandler()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryDataProvider.InternalOp.NativeMethodInfoPtr_WaitForCompletionHandler_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000646 RID: 1606 RVA: 0x0001E0B0 File Offset: 0x0001C2B0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1140037, RefRangeEnd = 1140038, XrefRangeStart = 1140005, XrefRangeEnd = 1140037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RequestOperation_completed(AsyncOperation op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryDataProvider.InternalOp.NativeMethodInfoPtr_RequestOperation_completed_Private_Void_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000647 RID: 1607 RVA: 0x0001E0F4 File Offset: 0x0001C2F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140038, XrefRangeEnd = 1140042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompleteOperation(Il2CppStructArray<byte> data, Exception exception)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryDataProvider.InternalOp.NativeMethodInfoPtr_CompleteOperation_Protected_Void_Il2CppStructArray_1_Byte_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000648 RID: 1608 RVA: 0x0001E148 File Offset: 0x0001C348
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1140050, RefRangeEnd = 1140054, XrefRangeStart = 1140042, XrefRangeEnd = 1140050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object ConvertBytes(Il2CppStructArray<byte> data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryDataProvider.InternalOp.NativeMethodInfoPtr_ConvertBytes_Private_Object_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000649 RID: 1609 RVA: 0x0001E198 File Offset: 0x0001C398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140054, XrefRangeEnd = 1140085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void SendWebRequest(string path)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryDataProvider.InternalOp.NativeMethodInfoPtr_SendWebRequest_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600064A RID: 1610 RVA: 0x0001E1E8 File Offset: 0x0001C3E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalOp()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryDataProvider.InternalOp>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryDataProvider.InternalOp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600064B RID: 1611 RVA: 0x0001E224 File Offset: 0x0001C424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140085, XrefRangeEnd = 1140094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SendWebRequest_b__13_0(UnityWebRequestAsyncOperation asyncOperation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncOperation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryDataProvider.InternalOp.NativeMethodInfoPtr__SendWebRequest_b__13_0_Private_Void_UnityWebRequestAsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600064C RID: 1612 RVA: 0x000045B6 File Offset: 0x000027B6
			public InternalOp(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001E1 RID: 481
			// (get) Token: 0x0600064D RID: 1613 RVA: 0x0001E268 File Offset: 0x0001C468
			// (set) Token: 0x0600064E RID: 1614 RVA: 0x000045BF File Offset: 0x000027BF
			public unsafe BinaryDataProvider m_Provider
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryDataProvider.InternalOp.NativeFieldInfoPtr_m_Provider);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryDataProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryDataProvider.InternalOp.NativeFieldInfoPtr_m_Provider), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001E2 RID: 482
			// (get) Token: 0x0600064F RID: 1615 RVA: 0x0001E298 File Offset: 0x0001C498
			// (set) Token: 0x06000650 RID: 1616 RVA: 0x000045DE File Offset: 0x000027DE
			public unsafe UnityWebRequestAsyncOperation m_RequestOperation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryDataProvider.InternalOp.NativeFieldInfoPtr_m_RequestOperation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequestAsyncOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryDataProvider.InternalOp.NativeFieldInfoPtr_m_RequestOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001E3 RID: 483
			// (get) Token: 0x06000651 RID: 1617 RVA: 0x0001E2C8 File Offset: 0x0001C4C8
			// (set) Token: 0x06000652 RID: 1618 RVA: 0x000045FD File Offset: 0x000027FD
			public unsafe WebRequestQueueOperation m_RequestQueueOperation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryDataProvider.InternalOp.NativeFieldInfoPtr_m_RequestQueueOperation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestQueueOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryDataProvider.InternalOp.NativeFieldInfoPtr_m_RequestQueueOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001E4 RID: 484
			// (get) Token: 0x06000653 RID: 1619 RVA: 0x0001E2F8 File Offset: 0x0001C4F8
			// (set) Token: 0x06000654 RID: 1620 RVA: 0x0000461C File Offset: 0x0000281C
			public ProvideHandle m_PI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryDataProvider.InternalOp.NativeFieldInfoPtr_m_PI);
					return new ProvideHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryDataProvider.InternalOp.NativeFieldInfoPtr_m_PI), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001E5 RID: 485
			// (get) Token: 0x06000655 RID: 1621 RVA: 0x0001E328 File Offset: 0x0001C528
			// (set) Token: 0x06000656 RID: 1622 RVA: 0x0000464A File Offset: 0x0000284A
			public unsafe bool m_IgnoreFailures
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryDataProvider.InternalOp.NativeFieldInfoPtr_m_IgnoreFailures);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryDataProvider.InternalOp.NativeFieldInfoPtr_m_IgnoreFailures)) = value;
				}
			}

			// Token: 0x170001E6 RID: 486
			// (get) Token: 0x06000657 RID: 1623 RVA: 0x0001E350 File Offset: 0x0001C550
			// (set) Token: 0x06000658 RID: 1624 RVA: 0x00004665 File Offset: 0x00002865
			public unsafe bool m_Complete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryDataProvider.InternalOp.NativeFieldInfoPtr_m_Complete);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryDataProvider.InternalOp.NativeFieldInfoPtr_m_Complete)) = value;
				}
			}

			// Token: 0x170001E7 RID: 487
			// (get) Token: 0x06000659 RID: 1625 RVA: 0x0001E378 File Offset: 0x0001C578
			// (set) Token: 0x0600065A RID: 1626 RVA: 0x00004680 File Offset: 0x00002880
			public unsafe int m_Timeout
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryDataProvider.InternalOp.NativeFieldInfoPtr_m_Timeout);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryDataProvider.InternalOp.NativeFieldInfoPtr_m_Timeout)) = value;
				}
			}

			// Token: 0x04000477 RID: 1143
			private static readonly IntPtr NativeFieldInfoPtr_m_Provider;

			// Token: 0x04000478 RID: 1144
			private static readonly IntPtr NativeFieldInfoPtr_m_RequestOperation;

			// Token: 0x04000479 RID: 1145
			private static readonly IntPtr NativeFieldInfoPtr_m_RequestQueueOperation;

			// Token: 0x0400047A RID: 1146
			private static readonly IntPtr NativeFieldInfoPtr_m_PI;

			// Token: 0x0400047B RID: 1147
			private static readonly IntPtr NativeFieldInfoPtr_m_IgnoreFailures;

			// Token: 0x0400047C RID: 1148
			private static readonly IntPtr NativeFieldInfoPtr_m_Complete;

			// Token: 0x0400047D RID: 1149
			private static readonly IntPtr NativeFieldInfoPtr_m_Timeout;

			// Token: 0x0400047E RID: 1150
			private static readonly IntPtr NativeMethodInfoPtr_GetPercentComplete_Private_Single_0;

			// Token: 0x0400047F RID: 1151
			private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_ProvideHandle_BinaryDataProvider_0;

			// Token: 0x04000480 RID: 1152
			private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletionHandler_Private_Boolean_0;

			// Token: 0x04000481 RID: 1153
			private static readonly IntPtr NativeMethodInfoPtr_RequestOperation_completed_Private_Void_AsyncOperation_0;

			// Token: 0x04000482 RID: 1154
			private static readonly IntPtr NativeMethodInfoPtr_CompleteOperation_Protected_Void_Il2CppStructArray_1_Byte_Exception_0;

			// Token: 0x04000483 RID: 1155
			private static readonly IntPtr NativeMethodInfoPtr_ConvertBytes_Private_Object_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000484 RID: 1156
			private static readonly IntPtr NativeMethodInfoPtr_SendWebRequest_Protected_Virtual_New_Void_String_0;

			// Token: 0x04000485 RID: 1157
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000486 RID: 1158
			private static readonly IntPtr NativeMethodInfoPtr__SendWebRequest_b__13_0_Private_Void_UnityWebRequestAsyncOperation_0;
		}
	}
}
