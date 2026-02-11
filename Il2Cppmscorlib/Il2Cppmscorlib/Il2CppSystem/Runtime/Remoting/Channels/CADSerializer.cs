using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020002CB RID: 715
	public class CADSerializer : Object
	{
		// Token: 0x06002D2C RID: 11564 RVA: 0x000EBC38 File Offset: 0x000E9E38
		// Note: this type is marked as 'beforefieldinit'.
		static CADSerializer()
		{
			Il2CppClassPointerStore<CADSerializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "CADSerializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr);
			CADSerializer.NativeMethodInfoPtr_DeserializeMessage_Internal_Static_IMessage_MemoryStream_IMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr, 100670560);
			CADSerializer.NativeMethodInfoPtr_SerializeMessage_Internal_Static_MemoryStream_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr, 100670561);
			CADSerializer.NativeMethodInfoPtr_DeserializeObjectSafe_Internal_Static_Object_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr, 100670562);
			CADSerializer.NativeMethodInfoPtr_SerializeObject_Internal_Static_MemoryStream_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr, 100670563);
			CADSerializer.NativeMethodInfoPtr_DeserializeObject_Internal_Static_Object_MemoryStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr, 100670564);
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x000EBCCC File Offset: 0x000E9ECC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1381745, RefRangeEnd = 1381746, XrefRangeStart = 1381740, XrefRangeEnd = 1381745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessage DeserializeMessage(MemoryStream mem, IMethodCallMessage msg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADSerializer.NativeMethodInfoPtr_DeserializeMessage_Internal_Static_IMessage_MemoryStream_IMethodCallMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x000EBD24 File Offset: 0x000E9F24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1381760, RefRangeEnd = 1381763, XrefRangeStart = 1381746, XrefRangeEnd = 1381760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MemoryStream SerializeMessage(IMessage msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADSerializer.NativeMethodInfoPtr_SerializeMessage_Internal_Static_MemoryStream_IMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr3) : null;
			}
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x000EBD68 File Offset: 0x000E9F68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1381778, RefRangeEnd = 1381779, XrefRangeStart = 1381763, XrefRangeEnd = 1381778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object DeserializeObjectSafe(Il2CppStructArray<byte> mem)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADSerializer.NativeMethodInfoPtr_DeserializeObjectSafe_Internal_Static_Object_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x000EBDAC File Offset: 0x000E9FAC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1381793, RefRangeEnd = 1381798, XrefRangeStart = 1381779, XrefRangeEnd = 1381793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MemoryStream SerializeObject(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADSerializer.NativeMethodInfoPtr_SerializeObject_Internal_Static_MemoryStream_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr3) : null;
			}
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x000EBDF0 File Offset: 0x000E9FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381798, XrefRangeEnd = 1381805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object DeserializeObject(MemoryStream mem)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADSerializer.NativeMethodInfoPtr_DeserializeObject_Internal_Static_Object_MemoryStream_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x0000F259 File Offset: 0x0000D459
		public CADSerializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040025F3 RID: 9715
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeMessage_Internal_Static_IMessage_MemoryStream_IMethodCallMessage_0;

		// Token: 0x040025F4 RID: 9716
		private static readonly IntPtr NativeMethodInfoPtr_SerializeMessage_Internal_Static_MemoryStream_IMessage_0;

		// Token: 0x040025F5 RID: 9717
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeObjectSafe_Internal_Static_Object_Il2CppStructArray_1_Byte_0;

		// Token: 0x040025F6 RID: 9718
		private static readonly IntPtr NativeMethodInfoPtr_SerializeObject_Internal_Static_MemoryStream_Object_0;

		// Token: 0x040025F7 RID: 9719
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeObject_Internal_Static_Object_MemoryStream_0;
	}
}
