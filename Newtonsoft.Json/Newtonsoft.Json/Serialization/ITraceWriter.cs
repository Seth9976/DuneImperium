using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Diagnostics;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200007E RID: 126
	public class ITraceWriter : Il2CppObjectBase
	{
		// Token: 0x06000A5B RID: 2651 RVA: 0x00042474 File Offset: 0x00040674
		// Note: this type is marked as 'beforefieldinit'.
		static ITraceWriter()
		{
			Il2CppClassPointerStore<ITraceWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "ITraceWriter");
			ITraceWriter.NativeMethodInfoPtr_get_LevelFilter_Public_Abstract_Virtual_New_get_TraceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITraceWriter>.NativeClassPtr, 100665288);
			ITraceWriter.NativeMethodInfoPtr_Trace_Public_Abstract_Virtual_New_Void_TraceLevel_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITraceWriter>.NativeClassPtr, 100665289);
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x000424C4 File Offset: 0x000406C4
		public unsafe virtual TraceLevel LevelFilter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITraceWriter.NativeMethodInfoPtr_get_LevelFilter_Public_Abstract_Virtual_New_get_TraceLevel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x0004250C File Offset: 0x0004070C
		[CallerCount(0)]
		public unsafe virtual void Trace(TraceLevel level, string message, Exception ex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITraceWriter.NativeMethodInfoPtr_Trace_Public_Abstract_Virtual_New_Void_TraceLevel_String_Exception_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00005279 File Offset: 0x00003479
		public ITraceWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr_get_LevelFilter_Public_Abstract_Virtual_New_get_TraceLevel_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr_Trace_Public_Abstract_Virtual_New_Void_TraceLevel_String_Exception_0;
	}
}
