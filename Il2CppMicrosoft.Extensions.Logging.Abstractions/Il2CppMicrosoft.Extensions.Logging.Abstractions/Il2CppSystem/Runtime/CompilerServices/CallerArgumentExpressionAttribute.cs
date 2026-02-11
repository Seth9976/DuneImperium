using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200000B RID: 11
	public sealed class CallerArgumentExpressionAttribute : Attribute
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00002CEC File Offset: 0x00000EEC
		// Note: this type is marked as 'beforefieldinit'.
		static CallerArgumentExpressionAttribute()
		{
			Il2CppClassPointerStore<CallerArgumentExpressionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.Abstractions.dll", "System.Runtime.CompilerServices", "CallerArgumentExpressionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallerArgumentExpressionAttribute>.NativeClassPtr);
			CallerArgumentExpressionAttribute.NativeFieldInfoPtr__ParameterName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallerArgumentExpressionAttribute>.NativeClassPtr, "<ParameterName>k__BackingField");
			CallerArgumentExpressionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallerArgumentExpressionAttribute>.NativeClassPtr, 100663308);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002D44 File Offset: 0x00000F44
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

		// Token: 0x0600002A RID: 42 RVA: 0x000021D7 File Offset: 0x000003D7
		public CallerArgumentExpressionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002D90 File Offset: 0x00000F90
		// (set) Token: 0x0600002C RID: 44 RVA: 0x000021E0 File Offset: 0x000003E0
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

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr__ParameterName_k__BackingField;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
