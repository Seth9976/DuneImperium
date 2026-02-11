using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000CD RID: 205
	public sealed class InterpretedFrameInfo : ValueType
	{
		// Token: 0x06000C65 RID: 3173 RVA: 0x00042B48 File Offset: 0x00040D48
		// Note: this type is marked as 'beforefieldinit'.
		static InterpretedFrameInfo()
		{
			Il2CppClassPointerStore<InterpretedFrameInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "InterpretedFrameInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InterpretedFrameInfo>.NativeClassPtr);
			InterpretedFrameInfo.NativeFieldInfoPtr__methodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpretedFrameInfo>.NativeClassPtr, "_methodName");
			InterpretedFrameInfo.NativeFieldInfoPtr__debugInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpretedFrameInfo>.NativeClassPtr, "_debugInfo");
			InterpretedFrameInfo.NativeMethodInfoPtr__ctor_Public_Void_String_DebugInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrameInfo>.NativeClassPtr, 100665536);
			InterpretedFrameInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrameInfo>.NativeClassPtr, 100665537);
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x00042BC8 File Offset: 0x00040DC8
		[CallerCount(238)]
		[CachedScanResults(RefRangeStart = 342357, RefRangeEnd = 342595, XrefRangeStart = 342357, XrefRangeEnd = 342595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InterpretedFrameInfo(string methodName, DebugInfo info)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InterpretedFrameInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrameInfo.NativeMethodInfoPtr__ctor_Public_Void_String_DebugInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x00042C2C File Offset: 0x00040E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020060, XrefRangeEnd = 1020063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrameInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00005CFE File Offset: 0x00003EFE
		public InterpretedFrameInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00005D07 File Offset: 0x00003F07
		public InterpretedFrameInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InterpretedFrameInfo>.NativeClassPtr))
		{
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x00042C68 File Offset: 0x00040E68
		// (set) Token: 0x06000C6B RID: 3179 RVA: 0x00005D19 File Offset: 0x00003F19
		public unsafe string _methodName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrameInfo.NativeFieldInfoPtr__methodName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrameInfo.NativeFieldInfoPtr__methodName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x00042C90 File Offset: 0x00040E90
		// (set) Token: 0x06000C6D RID: 3181 RVA: 0x00005D38 File Offset: 0x00003F38
		public unsafe DebugInfo _debugInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrameInfo.NativeFieldInfoPtr__debugInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrameInfo.NativeFieldInfoPtr__debugInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeFieldInfoPtr__methodName;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeFieldInfoPtr__debugInfo;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_DebugInfo_0;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
