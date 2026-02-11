using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002E9 RID: 745
	public class ArgInfo : Object
	{
		// Token: 0x06002E1B RID: 11803 RVA: 0x000EECD0 File Offset: 0x000ECED0
		// Note: this type is marked as 'beforefieldinit'.
		static ArgInfo()
		{
			Il2CppClassPointerStore<ArgInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ArgInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr);
			ArgInfo.NativeFieldInfoPtr__paramMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr, "_paramMap");
			ArgInfo.NativeFieldInfoPtr__inoutArgCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr, "_inoutArgCount");
			ArgInfo.NativeFieldInfoPtr__method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr, "_method");
			ArgInfo.NativeMethodInfoPtr__ctor_Public_Void_MethodBase_ArgInfoType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr, 100670665);
			ArgInfo.NativeMethodInfoPtr_GetInOutArgs_Public_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr, 100670666);
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x000EED64 File Offset: 0x000ECF64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1382473, RefRangeEnd = 1382475, XrefRangeStart = 1382462, XrefRangeEnd = 1382473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgInfo(MethodBase method, ArgInfoType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgInfo.NativeMethodInfoPtr__ctor_Public_Void_MethodBase_ArgInfoType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x000EEDC0 File Offset: 0x000ECFC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1382480, RefRangeEnd = 1382482, XrefRangeStart = 1382475, XrefRangeEnd = 1382480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetInOutArgs(Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgInfo.NativeMethodInfoPtr_GetInOutArgs_Public_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x0000F93D File Offset: 0x0000DB3D
		public ArgInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06002E1F RID: 11807 RVA: 0x000EEE10 File Offset: 0x000ED010
		// (set) Token: 0x06002E20 RID: 11808 RVA: 0x0000F946 File Offset: 0x0000DB46
		public unsafe Il2CppStructArray<int> _paramMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgInfo.NativeFieldInfoPtr__paramMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgInfo.NativeFieldInfoPtr__paramMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06002E21 RID: 11809 RVA: 0x000EEE40 File Offset: 0x000ED040
		// (set) Token: 0x06002E22 RID: 11810 RVA: 0x0000F965 File Offset: 0x0000DB65
		public unsafe int _inoutArgCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgInfo.NativeFieldInfoPtr__inoutArgCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgInfo.NativeFieldInfoPtr__inoutArgCount)) = value;
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06002E23 RID: 11811 RVA: 0x000EEE68 File Offset: 0x000ED068
		// (set) Token: 0x06002E24 RID: 11812 RVA: 0x0000F980 File Offset: 0x0000DB80
		public unsafe MethodBase _method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgInfo.NativeFieldInfoPtr__method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgInfo.NativeFieldInfoPtr__method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002682 RID: 9858
		private static readonly IntPtr NativeFieldInfoPtr__paramMap;

		// Token: 0x04002683 RID: 9859
		private static readonly IntPtr NativeFieldInfoPtr__inoutArgCount;

		// Token: 0x04002684 RID: 9860
		private static readonly IntPtr NativeFieldInfoPtr__method;

		// Token: 0x04002685 RID: 9861
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MethodBase_ArgInfoType_0;

		// Token: 0x04002686 RID: 9862
		private static readonly IntPtr NativeMethodInfoPtr_GetInOutArgs_Public_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0;
	}
}
