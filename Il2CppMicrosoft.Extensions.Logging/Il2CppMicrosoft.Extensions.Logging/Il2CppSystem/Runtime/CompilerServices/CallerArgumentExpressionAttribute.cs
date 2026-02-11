using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200000B RID: 11
	public sealed class CallerArgumentExpressionAttribute : Attribute
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00003104 File Offset: 0x00001304
		// Note: this type is marked as 'beforefieldinit'.
		static CallerArgumentExpressionAttribute()
		{
			Il2CppClassPointerStore<CallerArgumentExpressionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.dll", "System.Runtime.CompilerServices", "CallerArgumentExpressionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallerArgumentExpressionAttribute>.NativeClassPtr);
			CallerArgumentExpressionAttribute.NativeFieldInfoPtr__ParameterName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallerArgumentExpressionAttribute>.NativeClassPtr, "<ParameterName>k__BackingField");
			CallerArgumentExpressionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallerArgumentExpressionAttribute>.NativeClassPtr, 100663313);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000315C File Offset: 0x0000135C
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallerArgumentExpressionAttribute(string parameterName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallerArgumentExpressionAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(parameterName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallerArgumentExpressionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000021AE File Offset: 0x000003AE
		public CallerArgumentExpressionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000031A8 File Offset: 0x000013A8
		// (set) Token: 0x06000034 RID: 52 RVA: 0x000021B7 File Offset: 0x000003B7
		public unsafe string _ParameterName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallerArgumentExpressionAttribute.NativeFieldInfoPtr__ParameterName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallerArgumentExpressionAttribute.NativeFieldInfoPtr__ParameterName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr__ParameterName_k__BackingField;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
