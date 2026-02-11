using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000072 RID: 114
	[Serializable]
	public class ArgumentNullException : ArgumentException
	{
		// Token: 0x0600065B RID: 1627 RVA: 0x000425B4 File Offset: 0x000407B4
		// Note: this type is marked as 'beforefieldinit'.
		static ArgumentNullException()
		{
			Il2CppClassPointerStore<ArgumentNullException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ArgumentNullException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArgumentNullException>.NativeClassPtr);
			ArgumentNullException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentNullException>.NativeClassPtr, 100664348);
			ArgumentNullException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentNullException>.NativeClassPtr, 100664349);
			ArgumentNullException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentNullException>.NativeClassPtr, 100664350);
			ArgumentNullException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentNullException>.NativeClassPtr, 100664351);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00042634 File Offset: 0x00040834
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1297865, RefRangeEnd = 1297877, XrefRangeStart = 1297862, XrefRangeEnd = 1297865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentNullException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentNullException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentNullException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00042670 File Offset: 0x00040870
		[CallerCount(560)]
		[CachedScanResults(RefRangeStart = 1297881, RefRangeEnd = 1298441, XrefRangeStart = 1297877, XrefRangeEnd = 1297881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentNullException(string paramName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentNullException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentNullException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x000426BC File Offset: 0x000408BC
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 1298443, RefRangeEnd = 1298497, XrefRangeStart = 1298441, XrefRangeEnd = 1298443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentNullException(string paramName, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentNullException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentNullException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0004271C File Offset: 0x0004091C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1297842, RefRangeEnd = 1297847, XrefRangeStart = 1297842, XrefRangeEnd = 1297847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentNullException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentNullException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentNullException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00003F51 File Offset: 0x00002151
		public ArgumentNullException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
