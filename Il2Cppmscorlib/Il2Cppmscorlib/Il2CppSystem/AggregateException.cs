using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200006F RID: 111
	[Serializable]
	public class AggregateException : Exception
	{
		// Token: 0x06000634 RID: 1588 RVA: 0x00041990 File Offset: 0x0003FB90
		// Note: this type is marked as 'beforefieldinit'.
		static AggregateException()
		{
			Il2CppClassPointerStore<AggregateException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AggregateException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggregateException>.NativeClassPtr);
			AggregateException.NativeFieldInfoPtr_m_innerExceptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, "m_innerExceptions");
			AggregateException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664321);
			AggregateException.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664322);
			AggregateException.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664323);
			AggregateException.NativeMethodInfoPtr__ctor_Public_Void_String_IEnumerable_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664324);
			AggregateException.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664325);
			AggregateException.NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664326);
			AggregateException.NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664327);
			AggregateException.NativeMethodInfoPtr__ctor_Internal_Void_String_IEnumerable_1_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664328);
			AggregateException.NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664329);
			AggregateException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664330);
			AggregateException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664331);
			AggregateException.NativeMethodInfoPtr_get_InnerExceptions_Public_get_ReadOnlyCollection_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664332);
			AggregateException.NativeMethodInfoPtr_Flatten_Public_AggregateException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664333);
			AggregateException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664334);
			AggregateException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664335);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00041B00 File Offset: 0x0003FD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1296921, XrefRangeEnd = 1296940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00041B3C File Offset: 0x0003FD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1296940, XrefRangeEnd = 1296953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(IEnumerable<Exception> innerExceptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerExceptions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00041B88 File Offset: 0x0003FD88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1296956, RefRangeEnd = 1296958, XrefRangeStart = 1296953, XrefRangeEnd = 1296956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException([Optional] Il2CppReferenceArray<Exception> innerExceptions)
		{
			if (innerExceptions == null)
			{
				innerExceptions = new Il2CppReferenceArray<Exception>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerExceptions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00041BE0 File Offset: 0x0003FDE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1296969, RefRangeEnd = 1296970, XrefRangeStart = 1296958, XrefRangeEnd = 1296969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(string message, IEnumerable<Exception> innerExceptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerExceptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Public_Void_String_IEnumerable_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00041C40 File Offset: 0x0003FE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1296970, XrefRangeEnd = 1296971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(string message, [Optional] Il2CppReferenceArray<Exception> innerExceptions)
		{
			if (innerExceptions == null)
			{
				innerExceptions = new Il2CppReferenceArray<Exception>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerExceptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00041CAC File Offset: 0x0003FEAC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1297015, RefRangeEnd = 1297020, XrefRangeStart = 1296971, XrefRangeEnd = 1297015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(string message, IList<Exception> innerExceptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerExceptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00041D0C File Offset: 0x0003FF0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1297033, RefRangeEnd = 1297034, XrefRangeStart = 1297020, XrefRangeEnd = 1297033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(IEnumerable<ExceptionDispatchInfo> innerExceptionInfos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerExceptionInfos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00041D58 File Offset: 0x0003FF58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1297045, RefRangeEnd = 1297046, XrefRangeStart = 1297034, XrefRangeEnd = 1297045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(string message, IEnumerable<ExceptionDispatchInfo> innerExceptionInfos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerExceptionInfos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Internal_Void_String_IEnumerable_1_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00041DB8 File Offset: 0x0003FFB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1297092, RefRangeEnd = 1297094, XrefRangeStart = 1297046, XrefRangeEnd = 1297092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(string message, IList<ExceptionDispatchInfo> innerExceptionInfos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerExceptionInfos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00041E18 File Offset: 0x00040018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1297094, XrefRangeEnd = 1297129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00041E7C File Offset: 0x0004007C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1297129, XrefRangeEnd = 1297148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AggregateException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x00041EE0 File Offset: 0x000400E0
		public unsafe ReadOnlyCollection<Exception> InnerExceptions
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr_get_InnerExceptions_Public_get_ReadOnlyCollection_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Exception>>(intPtr3) : null;
			}
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00041F20 File Offset: 0x00040120
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1297187, RefRangeEnd = 1297189, XrefRangeStart = 1297148, XrefRangeEnd = 1297187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException Flatten()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr_Flatten_Public_AggregateException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AggregateException>(intPtr3) : null;
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x00041F60 File Offset: 0x00040160
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1297189, XrefRangeEnd = 1297210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AggregateException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00041FA4 File Offset: 0x000401A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1297210, XrefRangeEnd = 1297244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AggregateException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00003EDB File Offset: 0x000020DB
		public AggregateException(params Exception[] innerExceptions)
			: this(new Il2CppReferenceArray<Exception>(innerExceptions))
		{
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00003EE9 File Offset: 0x000020E9
		public AggregateException(string message, params Exception[] innerExceptions)
			: this(message, new Il2CppReferenceArray<Exception>(innerExceptions))
		{
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00003EF8 File Offset: 0x000020F8
		public AggregateException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x00041FE8 File Offset: 0x000401E8
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x00003F01 File Offset: 0x00002101
		public unsafe ReadOnlyCollection<Exception> m_innerExceptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AggregateException.NativeFieldInfoPtr_m_innerExceptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Exception>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AggregateException.NativeFieldInfoPtr_m_innerExceptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeFieldInfoPtr_m_innerExceptions;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Exception_0;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Exception_0;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_IEnumerable_1_Exception_0;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Exception_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_Exception_0;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_ExceptionDispatchInfo_0;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_IEnumerable_1_ExceptionDispatchInfo_0;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_ExceptionDispatchInfo_0;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerExceptions_Public_get_ReadOnlyCollection_1_Exception_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_Flatten_Public_AggregateException_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
