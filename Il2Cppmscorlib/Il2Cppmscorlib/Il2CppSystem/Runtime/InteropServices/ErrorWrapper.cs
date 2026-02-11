using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000380 RID: 896
	public sealed class ErrorWrapper : Object
	{
		// Token: 0x0600378E RID: 14222 RVA: 0x000144A3 File Offset: 0x000126A3
		// Note: this type is marked as 'beforefieldinit'.
		static ErrorWrapper()
		{
			Il2CppClassPointerStore<ErrorWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ErrorWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ErrorWrapper>.NativeClassPtr);
			ErrorWrapper.NativeFieldInfoPtr_m_ErrorCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorWrapper>.NativeClassPtr, "m_ErrorCode");
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x000144DC File Offset: 0x000126DC
		public ErrorWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06003790 RID: 14224 RVA: 0x0010FCDC File Offset: 0x0010DEDC
		// (set) Token: 0x06003791 RID: 14225 RVA: 0x000144E5 File Offset: 0x000126E5
		public unsafe int m_ErrorCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorWrapper.NativeFieldInfoPtr_m_ErrorCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorWrapper.NativeFieldInfoPtr_m_ErrorCode)) = value;
			}
		}

		// Token: 0x04002D20 RID: 11552
		private static readonly IntPtr NativeFieldInfoPtr_m_ErrorCode;
	}
}
