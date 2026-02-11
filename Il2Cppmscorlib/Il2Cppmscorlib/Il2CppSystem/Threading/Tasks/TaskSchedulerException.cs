using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001C8 RID: 456
	[Serializable]
	public class TaskSchedulerException : Exception
	{
		// Token: 0x06001DE6 RID: 7654 RVA: 0x000AE20C File Offset: 0x000AC40C
		// Note: this type is marked as 'beforefieldinit'.
		static TaskSchedulerException()
		{
			Il2CppClassPointerStore<TaskSchedulerException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskSchedulerException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskSchedulerException>.NativeClassPtr);
			TaskSchedulerException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskSchedulerException>.NativeClassPtr, 100668371);
			TaskSchedulerException.NativeMethodInfoPtr__ctor_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskSchedulerException>.NativeClassPtr, 100668372);
			TaskSchedulerException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskSchedulerException>.NativeClassPtr, 100668373);
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x000AE278 File Offset: 0x000AC478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357904, XrefRangeEnd = 1357910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskSchedulerException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskSchedulerException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskSchedulerException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x000AE2B4 File Offset: 0x000AC4B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1357916, RefRangeEnd = 1357918, XrefRangeStart = 1357910, XrefRangeEnd = 1357916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskSchedulerException(Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskSchedulerException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerException);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskSchedulerException.NativeMethodInfoPtr__ctor_Public_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x000AE300 File Offset: 0x000AC500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357918, XrefRangeEnd = 1357922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskSchedulerException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskSchedulerException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskSchedulerException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x00009CBB File Offset: 0x00007EBB
		public TaskSchedulerException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001AC4 RID: 6852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001AC5 RID: 6853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Exception_0;

		// Token: 0x04001AC6 RID: 6854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
