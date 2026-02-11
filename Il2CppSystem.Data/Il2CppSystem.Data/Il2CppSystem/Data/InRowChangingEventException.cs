using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Data
{
	// Token: 0x02000010 RID: 16
	[Serializable]
	public class InRowChangingEventException : DataException
	{
		// Token: 0x06000128 RID: 296 RVA: 0x0000CC4C File Offset: 0x0000AE4C
		// Note: this type is marked as 'beforefieldinit'.
		static InRowChangingEventException()
		{
			Il2CppClassPointerStore<InRowChangingEventException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "InRowChangingEventException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InRowChangingEventException>.NativeClassPtr);
			InRowChangingEventException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InRowChangingEventException>.NativeClassPtr, 100663471);
			InRowChangingEventException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InRowChangingEventException>.NativeClassPtr, 100663472);
			InRowChangingEventException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InRowChangingEventException>.NativeClassPtr, 100663473);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000CCB8 File Offset: 0x0000AEB8
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InRowChangingEventException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InRowChangingEventException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InRowChangingEventException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000CD1C File Offset: 0x0000AF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888613, XrefRangeEnd = 888616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InRowChangingEventException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InRowChangingEventException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InRowChangingEventException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000CD58 File Offset: 0x0000AF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888616, XrefRangeEnd = 888617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InRowChangingEventException(string s)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InRowChangingEventException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InRowChangingEventException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002648 File Offset: 0x00000848
		public InRowChangingEventException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
