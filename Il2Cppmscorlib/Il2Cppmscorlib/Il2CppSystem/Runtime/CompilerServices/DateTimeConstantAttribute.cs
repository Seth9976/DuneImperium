using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003B2 RID: 946
	[Serializable]
	public sealed class DateTimeConstantAttribute : CustomConstantAttribute
	{
		// Token: 0x060038FC RID: 14588 RVA: 0x00114AF8 File Offset: 0x00112CF8
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeConstantAttribute()
		{
			Il2CppClassPointerStore<DateTimeConstantAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "DateTimeConstantAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeConstantAttribute>.NativeClassPtr);
			DateTimeConstantAttribute.NativeFieldInfoPtr__date = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeConstantAttribute>.NativeClassPtr, "_date");
			DateTimeConstantAttribute.NativeMethodInfoPtr_get_Value_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeConstantAttribute>.NativeClassPtr, 100671809);
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x060038FD RID: 14589 RVA: 0x00114B50 File Offset: 0x00112D50
		public unsafe override Object Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392923, XrefRangeEnd = 1392926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeConstantAttribute.NativeMethodInfoPtr_get_Value_Public_Virtual_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060038FE RID: 14590 RVA: 0x00014FC5 File Offset: 0x000131C5
		public DateTimeConstantAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x060038FF RID: 14591 RVA: 0x00114B90 File Offset: 0x00112D90
		// (set) Token: 0x06003900 RID: 14592 RVA: 0x00014FCE File Offset: 0x000131CE
		public unsafe DateTime _date
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeConstantAttribute.NativeFieldInfoPtr__date);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeConstantAttribute.NativeFieldInfoPtr__date)) = value;
			}
		}

		// Token: 0x04002E74 RID: 11892
		private static readonly IntPtr NativeFieldInfoPtr__date;

		// Token: 0x04002E75 RID: 11893
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_Object_0;
	}
}
