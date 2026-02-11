using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000E1 RID: 225
	public class DateTimeConverterBase : JsonConverter
	{
		// Token: 0x060013A5 RID: 5029 RVA: 0x0006C4D4 File Offset: 0x0006A6D4
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeConverterBase()
		{
			Il2CppClassPointerStore<DateTimeConverterBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "DateTimeConverterBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeConverterBase>.NativeClassPtr);
			DateTimeConverterBase.NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeConverterBase>.NativeClassPtr, 100667056);
			DateTimeConverterBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeConverterBase>.NativeClassPtr, 100667057);
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x0006C52C File Offset: 0x0006A72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764102, XrefRangeEnd = 764127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanConvert(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DateTimeConverterBase.NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x0006C584 File Offset: 0x0006A784
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeConverterBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeConverterBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeConverterBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x000080A3 File Offset: 0x000062A3
		public DateTimeConverterBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FF9 RID: 4089
		private static readonly IntPtr NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0;

		// Token: 0x04000FFA RID: 4090
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
