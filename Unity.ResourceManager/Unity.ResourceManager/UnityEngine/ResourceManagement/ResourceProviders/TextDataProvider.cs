using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Networking;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x02000045 RID: 69
	public class TextDataProvider : ResourceProviderBase
	{
		// Token: 0x06000365 RID: 869 RVA: 0x0001217C File Offset: 0x0001037C
		// Note: this type is marked as 'beforefieldinit'.
		static TextDataProvider()
		{
			Il2CppClassPointerStore<TextDataProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "TextDataProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextDataProvider>.NativeClassPtr);
			TextDataProvider.NativeFieldInfoPtr__IgnoreFailures_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextDataProvider>.NativeClassPtr, "<IgnoreFailures>k__BackingField");
			TextDataProvider.NativeMethodInfoPtr_get_IgnoreFailures_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDataProvider>.NativeClassPtr, 100663876);
			TextDataProvider.NativeMethodInfoPtr_set_IgnoreFailures_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDataProvider>.NativeClassPtr, 100663877);
			TextDataProvider.NativeMethodInfoPtr_Convert_Public_Virtual_New_Object_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDataProvider>.NativeClassPtr, 100663878);
			TextDataProvider.NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDataProvider>.NativeClassPtr, 100663879);
			TextDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDataProvider>.NativeClassPtr, 100663880);
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00012224 File Offset: 0x00010424
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00012260 File Offset: 0x00010460
		public unsafe bool IgnoreFailures
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextDataProvider.NativeMethodInfoPtr_get_IgnoreFailures_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextDataProvider.NativeMethodInfoPtr_set_IgnoreFailures_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x000122A0 File Offset: 0x000104A0
		[CallerCount(0)]
		public unsafe virtual Object Convert(Type type, string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextDataProvider.NativeMethodInfoPtr_Convert_Public_Virtual_New_Object_Type_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00012310 File Offset: 0x00010510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141374, XrefRangeEnd = 1141379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Provide(ProvideHandle provideHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(provideHandle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextDataProvider.NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00012364 File Offset: 0x00010564
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextDataProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextDataProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000358F File Offset: 0x0000178F
		public TextDataProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600036C RID: 876 RVA: 0x000123A0 File Offset: 0x000105A0
		// (set) Token: 0x0600036D RID: 877 RVA: 0x00003598 File Offset: 0x00001798
		public unsafe bool _IgnoreFailures_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDataProvider.NativeFieldInfoPtr__IgnoreFailures_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDataProvider.NativeFieldInfoPtr__IgnoreFailures_k__BackingField)) = value;
			}
		}

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeFieldInfoPtr__IgnoreFailures_k__BackingField;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreFailures_Public_get_Boolean_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreFailures_Public_set_Void_Boolean_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_New_Object_Type_String_0;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200008B RID: 139
		public class InternalOp : Object
		{
			// Token: 0x060006C3 RID: 1731 RVA: 0x0001FB08 File Offset: 0x0001DD08
			// Note: this type is marked as 'beforefieldinit'.
			static InternalOp()
			{
				Il2CppClassPointerStore<TextDataProvider.InternalOp>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextDataProvider>.NativeClassPtr, "InternalOp");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextDataProvider.InternalOp>.NativeClassPtr);
				TextDataProvider.InternalOp.NativeFieldInfoPtr_m_Provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextDataProvider.InternalOp>.NativeClassPtr, "m_Provider");
				TextDataProvider.InternalOp.NativeFieldInfoPtr_m_RequestOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextDataProvider.InternalOp>.NativeClassPtr, "m_RequestOperation");
				TextDataProvider.InternalOp.NativeFieldInfoPtr_m_RequestQueueOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextDataProvider.InternalOp>.NativeClassPtr, "m_RequestQueueOperation");
				TextDataProvider.InternalOp.NativeFieldInfoPtr_m_PI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextDataProvider.InternalOp>.NativeClassPtr, "m_PI");
				TextDataProvider.InternalOp.NativeFieldInfoPtr_m_IgnoreFailures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextDataProvider.InternalOp>.NativeClassPtr, "m_IgnoreFailures");
				TextDataProvider.InternalOp.NativeFieldInfoPtr_m_Complete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextDataProvider.InternalOp>.NativeClassPtr, "m_Complete");
				TextDataProvider.InternalOp.NativeFieldInfoPtr_m_Timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextDataProvider.InternalOp>.NativeClassPtr, "m_Timeout");
				TextDataProvider.InternalOp.NativeMethodInfoPtr_GetPercentComplete_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDataProvider.InternalOp>.NativeClassPtr, 100663881);
				TextDataProvider.InternalOp.NativeMethodInfoPtr_Start_Public_Void_ProvideHandle_TextDataProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDataProvider.InternalOp>.NativeClassPtr, 100663882);
				TextDataProvider.InternalOp.NativeMethodInfoPtr_WaitForCompletionHandler_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDataProvider.InternalOp>.NativeClassPtr, 100663883);
				TextDataProvider.InternalOp.NativeMethodInfoPtr_RequestOperation_completed_Private_Void_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDataProvider.InternalOp>.NativeClassPtr, 100663884);
				TextDataProvider.InternalOp.NativeMethodInfoPtr_CompleteOperation_Protected_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDataProvider.InternalOp>.NativeClassPtr, 100663885);
				TextDataProvider.InternalOp.NativeMethodInfoPtr_ConvertText_Private_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDataProvider.InternalOp>.NativeClassPtr, 100663886);
				TextDataProvider.InternalOp.NativeMethodInfoPtr_SendWebRequest_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDataProvider.InternalOp>.NativeClassPtr, 100663887);
				TextDataProvider.InternalOp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDataProvider.InternalOp>.NativeClassPtr, 100663888);
				TextDataProvider.InternalOp.NativeMethodInfoPtr__SendWebRequest_b__13_0_Private_Void_UnityWebRequestAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDataProvider.InternalOp>.NativeClassPtr, 100663889);
			}

			// Token: 0x060006C4 RID: 1732 RVA: 0x0001FC74 File Offset: 0x0001DE74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float GetPercentComplete()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextDataProvider.InternalOp.NativeMethodInfoPtr_GetPercentComplete_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006C5 RID: 1733 RVA: 0x0001FCB0 File Offset: 0x0001DEB0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1141280, RefRangeEnd = 1141281, XrefRangeStart = 1141231, XrefRangeEnd = 1141280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Start(ProvideHandle provideHandle, TextDataProvider rawProvider)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextDataProvider.InternalOp.NativeMethodInfoPtr_Start_Public_Void_ProvideHandle_TextDataProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006C6 RID: 1734 RVA: 0x0001FD0C File Offset: 0x0001DF0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141281, XrefRangeEnd = 1141283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool WaitForCompletionHandler()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextDataProvider.InternalOp.NativeMethodInfoPtr_WaitForCompletionHandler_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006C7 RID: 1735 RVA: 0x0001FD48 File Offset: 0x0001DF48
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1141316, RefRangeEnd = 1141318, XrefRangeStart = 1141283, XrefRangeEnd = 1141316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RequestOperation_completed(AsyncOperation op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextDataProvider.InternalOp.NativeMethodInfoPtr_RequestOperation_completed_Private_Void_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006C8 RID: 1736 RVA: 0x0001FD8C File Offset: 0x0001DF8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141318, XrefRangeEnd = 1141323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompleteOperation(string text, Exception exception)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextDataProvider.InternalOp.NativeMethodInfoPtr_CompleteOperation_Protected_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006C9 RID: 1737 RVA: 0x0001FDE0 File Offset: 0x0001DFE0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1140050, RefRangeEnd = 1140054, XrefRangeStart = 1140050, XrefRangeEnd = 1140054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object ConvertText(string text)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextDataProvider.InternalOp.NativeMethodInfoPtr_ConvertText_Private_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060006CA RID: 1738 RVA: 0x0001FE30 File Offset: 0x0001E030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141323, XrefRangeEnd = 1141365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void SendWebRequest(string path)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextDataProvider.InternalOp.NativeMethodInfoPtr_SendWebRequest_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006CB RID: 1739 RVA: 0x0001FE80 File Offset: 0x0001E080
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalOp()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextDataProvider.InternalOp>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextDataProvider.InternalOp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006CC RID: 1740 RVA: 0x0001FEBC File Offset: 0x0001E0BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141365, XrefRangeEnd = 1141374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SendWebRequest_b__13_0(UnityWebRequestAsyncOperation asyncOperation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncOperation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextDataProvider.InternalOp.NativeMethodInfoPtr__SendWebRequest_b__13_0_Private_Void_UnityWebRequestAsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006CD RID: 1741 RVA: 0x000049E4 File Offset: 0x00002BE4
			public InternalOp(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000202 RID: 514
			// (get) Token: 0x060006CE RID: 1742 RVA: 0x0001FF00 File Offset: 0x0001E100
			// (set) Token: 0x060006CF RID: 1743 RVA: 0x000049ED File Offset: 0x00002BED
			public unsafe TextDataProvider m_Provider
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDataProvider.InternalOp.NativeFieldInfoPtr_m_Provider);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextDataProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDataProvider.InternalOp.NativeFieldInfoPtr_m_Provider), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000203 RID: 515
			// (get) Token: 0x060006D0 RID: 1744 RVA: 0x0001FF30 File Offset: 0x0001E130
			// (set) Token: 0x060006D1 RID: 1745 RVA: 0x00004A0C File Offset: 0x00002C0C
			public unsafe UnityWebRequestAsyncOperation m_RequestOperation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDataProvider.InternalOp.NativeFieldInfoPtr_m_RequestOperation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequestAsyncOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDataProvider.InternalOp.NativeFieldInfoPtr_m_RequestOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000204 RID: 516
			// (get) Token: 0x060006D2 RID: 1746 RVA: 0x0001FF60 File Offset: 0x0001E160
			// (set) Token: 0x060006D3 RID: 1747 RVA: 0x00004A2B File Offset: 0x00002C2B
			public unsafe WebRequestQueueOperation m_RequestQueueOperation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDataProvider.InternalOp.NativeFieldInfoPtr_m_RequestQueueOperation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestQueueOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDataProvider.InternalOp.NativeFieldInfoPtr_m_RequestQueueOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000205 RID: 517
			// (get) Token: 0x060006D4 RID: 1748 RVA: 0x0001FF90 File Offset: 0x0001E190
			// (set) Token: 0x060006D5 RID: 1749 RVA: 0x00004A4A File Offset: 0x00002C4A
			public ProvideHandle m_PI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDataProvider.InternalOp.NativeFieldInfoPtr_m_PI);
					return new ProvideHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDataProvider.InternalOp.NativeFieldInfoPtr_m_PI), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000206 RID: 518
			// (get) Token: 0x060006D6 RID: 1750 RVA: 0x0001FFC0 File Offset: 0x0001E1C0
			// (set) Token: 0x060006D7 RID: 1751 RVA: 0x00004A78 File Offset: 0x00002C78
			public unsafe bool m_IgnoreFailures
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDataProvider.InternalOp.NativeFieldInfoPtr_m_IgnoreFailures);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDataProvider.InternalOp.NativeFieldInfoPtr_m_IgnoreFailures)) = value;
				}
			}

			// Token: 0x17000207 RID: 519
			// (get) Token: 0x060006D8 RID: 1752 RVA: 0x0001FFE8 File Offset: 0x0001E1E8
			// (set) Token: 0x060006D9 RID: 1753 RVA: 0x00004A93 File Offset: 0x00002C93
			public unsafe bool m_Complete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDataProvider.InternalOp.NativeFieldInfoPtr_m_Complete);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDataProvider.InternalOp.NativeFieldInfoPtr_m_Complete)) = value;
				}
			}

			// Token: 0x17000208 RID: 520
			// (get) Token: 0x060006DA RID: 1754 RVA: 0x00020010 File Offset: 0x0001E210
			// (set) Token: 0x060006DB RID: 1755 RVA: 0x00004AAE File Offset: 0x00002CAE
			public unsafe int m_Timeout
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDataProvider.InternalOp.NativeFieldInfoPtr_m_Timeout);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextDataProvider.InternalOp.NativeFieldInfoPtr_m_Timeout)) = value;
				}
			}

			// Token: 0x040004CC RID: 1228
			private static readonly IntPtr NativeFieldInfoPtr_m_Provider;

			// Token: 0x040004CD RID: 1229
			private static readonly IntPtr NativeFieldInfoPtr_m_RequestOperation;

			// Token: 0x040004CE RID: 1230
			private static readonly IntPtr NativeFieldInfoPtr_m_RequestQueueOperation;

			// Token: 0x040004CF RID: 1231
			private static readonly IntPtr NativeFieldInfoPtr_m_PI;

			// Token: 0x040004D0 RID: 1232
			private static readonly IntPtr NativeFieldInfoPtr_m_IgnoreFailures;

			// Token: 0x040004D1 RID: 1233
			private static readonly IntPtr NativeFieldInfoPtr_m_Complete;

			// Token: 0x040004D2 RID: 1234
			private static readonly IntPtr NativeFieldInfoPtr_m_Timeout;

			// Token: 0x040004D3 RID: 1235
			private static readonly IntPtr NativeMethodInfoPtr_GetPercentComplete_Private_Single_0;

			// Token: 0x040004D4 RID: 1236
			private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_ProvideHandle_TextDataProvider_0;

			// Token: 0x040004D5 RID: 1237
			private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletionHandler_Private_Boolean_0;

			// Token: 0x040004D6 RID: 1238
			private static readonly IntPtr NativeMethodInfoPtr_RequestOperation_completed_Private_Void_AsyncOperation_0;

			// Token: 0x040004D7 RID: 1239
			private static readonly IntPtr NativeMethodInfoPtr_CompleteOperation_Protected_Void_String_Exception_0;

			// Token: 0x040004D8 RID: 1240
			private static readonly IntPtr NativeMethodInfoPtr_ConvertText_Private_Object_String_0;

			// Token: 0x040004D9 RID: 1241
			private static readonly IntPtr NativeMethodInfoPtr_SendWebRequest_Protected_Virtual_New_Void_String_0;

			// Token: 0x040004DA RID: 1242
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004DB RID: 1243
			private static readonly IntPtr NativeMethodInfoPtr__SendWebRequest_b__13_0_Private_Void_UnityWebRequestAsyncOperation_0;
		}
	}
}
