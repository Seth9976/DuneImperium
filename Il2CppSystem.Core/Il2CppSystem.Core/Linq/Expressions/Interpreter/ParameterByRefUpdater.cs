using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000D0 RID: 208
	public sealed class ParameterByRefUpdater : ByRefUpdater
	{
		// Token: 0x06000CE5 RID: 3301 RVA: 0x00045304 File Offset: 0x00043504
		// Note: this type is marked as 'beforefieldinit'.
		static ParameterByRefUpdater()
		{
			Il2CppClassPointerStore<ParameterByRefUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "ParameterByRefUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterByRefUpdater>.NativeClassPtr);
			ParameterByRefUpdater.NativeFieldInfoPtr__parameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterByRefUpdater>.NativeClassPtr, "_parameter");
			ParameterByRefUpdater.NativeMethodInfoPtr__ctor_Public_Void_LocalVariable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterByRefUpdater>.NativeClassPtr, 100665646);
			ParameterByRefUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_InterpretedFrame_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterByRefUpdater>.NativeClassPtr, 100665647);
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00045370 File Offset: 0x00043570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 573396, RefRangeEnd = 573397, XrefRangeStart = 573396, XrefRangeEnd = 573397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParameterByRefUpdater(LocalVariable parameter, int argumentIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterByRefUpdater>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argumentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterByRefUpdater.NativeMethodInfoPtr__ctor_Public_Void_LocalVariable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x000453CC File Offset: 0x000435CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022360, XrefRangeEnd = 1022376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update(InterpretedFrame frame, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterByRefUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_InterpretedFrame_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x00005E8E File Offset: 0x0000408E
		public ParameterByRefUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x00045420 File Offset: 0x00043620
		// (set) Token: 0x06000CEA RID: 3306 RVA: 0x00005E97 File Offset: 0x00004097
		public unsafe LocalVariable _parameter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterByRefUpdater.NativeFieldInfoPtr__parameter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalVariable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterByRefUpdater.NativeFieldInfoPtr__parameter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeFieldInfoPtr__parameter;

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LocalVariable_Int32_0;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_InterpretedFrame_Object_0;
	}
}
