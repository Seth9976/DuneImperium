using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Unity.Collections;

namespace UnityEngine.Networking
{
	// Token: 0x0200000C RID: 12
	public sealed class UploadHandlerRaw : UploadHandler
	{
		// Token: 0x0600014E RID: 334 RVA: 0x00007370 File Offset: 0x00005570
		// Note: this type is marked as 'beforefieldinit'.
		static UploadHandlerRaw()
		{
			Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine.Networking", "UploadHandlerRaw");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr);
			UploadHandlerRaw.NativeFieldInfoPtr_m_Payload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr, "m_Payload");
			UploadHandlerRaw.NativeMethodInfoPtr_Create_Private_Static_IntPtr_UploadHandlerRaw_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr, 100663447);
			UploadHandlerRaw.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr, 100663448);
			UploadHandlerRaw.NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr, 100663449);
			UploadHandlerRaw.NativeMethodInfoPtr_GetData_Internal_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr, 100663450);
			UploadHandlerRaw.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr, 100663451);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00007418 File Offset: 0x00005618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247766, XrefRangeEnd = 1247768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Create(UploadHandlerRaw self, byte* data, int dataLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UploadHandlerRaw.NativeMethodInfoPtr_Create_Private_Static_IntPtr_UploadHandlerRaw_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00007474 File Offset: 0x00005674
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1247779, RefRangeEnd = 1247788, XrefRangeStart = 1247768, XrefRangeEnd = 1247779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UploadHandlerRaw(Il2CppStructArray<byte> data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UploadHandlerRaw.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000074C0 File Offset: 0x000056C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247788, XrefRangeEnd = 1247798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UploadHandlerRaw(NativeArray<byte> data, bool transferOwnership)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transferOwnership;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UploadHandlerRaw.NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_Byte_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00007520 File Offset: 0x00005720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247798, XrefRangeEnd = 1247800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UploadHandlerRaw.NativeMethodInfoPtr_GetData_Internal_Virtual_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00007560 File Offset: 0x00005760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247800, XrefRangeEnd = 1247807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UploadHandlerRaw.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000025DC File Offset: 0x000007DC
		public UploadHandlerRaw(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00007594 File Offset: 0x00005794
		// (set) Token: 0x06000156 RID: 342 RVA: 0x000025E5 File Offset: 0x000007E5
		public NativeArray<byte> m_Payload
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UploadHandlerRaw.NativeFieldInfoPtr_m_Payload);
				return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UploadHandlerRaw.NativeFieldInfoPtr_m_Payload), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeFieldInfoPtr_m_Payload;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Static_IntPtr_UploadHandlerRaw_ptr_Byte_Int32_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_Byte_Boolean_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Internal_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;
	}
}
