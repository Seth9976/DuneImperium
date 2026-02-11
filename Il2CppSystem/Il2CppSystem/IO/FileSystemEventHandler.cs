using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x02000177 RID: 375
	public sealed class FileSystemEventHandler : MulticastDelegate
	{
		// Token: 0x060016FE RID: 5886 RVA: 0x000767F4 File Offset: 0x000749F4
		// Note: this type is marked as 'beforefieldinit'.
		static FileSystemEventHandler()
		{
			Il2CppClassPointerStore<FileSystemEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.IO", "FileSystemEventHandler");
			FileSystemEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEventHandler>.NativeClassPtr, 100666960);
			FileSystemEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_FileSystemEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEventHandler>.NativeClassPtr, 100666961);
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x00076844 File Offset: 0x00074A44
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileSystemEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x000768A0 File Offset: 0x00074AA0
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, FileSystemEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_FileSystemEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x00009E70 File Offset: 0x00008070
		public FileSystemEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x00009E79 File Offset: 0x00008079
		public static implicit operator FileSystemEventHandler(Action<Object, FileSystemEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<FileSystemEventHandler>(A_0);
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x00009E81 File Offset: 0x00008081
		public static FileSystemEventHandler operator +(FileSystemEventHandler A_0, FileSystemEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<FileSystemEventHandler>();
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x00009E8F File Offset: 0x0000808F
		public static FileSystemEventHandler operator -(FileSystemEventHandler A_0, FileSystemEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<FileSystemEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x040011F7 RID: 4599
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040011F8 RID: 4600
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_FileSystemEventArgs_0;
	}
}
