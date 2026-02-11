using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200000C RID: 12
	public sealed class CallerArgumentExpressionAttribute : Attribute
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00002DB0 File Offset: 0x00000FB0
		// Note: this type is marked as 'beforefieldinit'.
		static CallerArgumentExpressionAttribute()
		{
			Il2CppClassPointerStore<CallerArgumentExpressionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.Abstractions.dll", "System.Runtime.CompilerServices", "CallerArgumentExpressionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallerArgumentExpressionAttribute>.NativeClassPtr);
			CallerArgumentExpressionAttribute.NativeFieldInfoPtr__ParameterName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallerArgumentExpressionAttribute>.NativeClassPtr, "<ParameterName>k__BackingField");
			CallerArgumentExpressionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallerArgumentExpressionAttribute>.NativeClassPtr, 100663317);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002E08 File Offset: 0x00001008
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

		// Token: 0x06000036 RID: 54 RVA: 0x000021AA File Offset: 0x000003AA
		public CallerArgumentExpressionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002E54 File Offset: 0x00001054
		// (set) Token: 0x06000038 RID: 56 RVA: 0x000021B3 File Offset: 0x000003B3
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

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr__ParameterName_k__BackingField;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
