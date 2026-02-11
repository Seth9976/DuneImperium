using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003B1 RID: 945
	[Serializable]
	public class CustomConstantAttribute : Attribute
	{
		// Token: 0x060038F8 RID: 14584 RVA: 0x00114A18 File Offset: 0x00112C18
		// Note: this type is marked as 'beforefieldinit'.
		static CustomConstantAttribute()
		{
			Il2CppClassPointerStore<CustomConstantAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "CustomConstantAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomConstantAttribute>.NativeClassPtr);
			CustomConstantAttribute.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomConstantAttribute>.NativeClassPtr, 100671807);
			CustomConstantAttribute.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomConstantAttribute>.NativeClassPtr, 100671808);
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x060038F9 RID: 14585 RVA: 0x00114A70 File Offset: 0x00112C70
		public unsafe virtual Object Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomConstantAttribute.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060038FA RID: 14586 RVA: 0x00114ABC File Offset: 0x00112CBC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomConstantAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomConstantAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomConstantAttribute.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038FB RID: 14587 RVA: 0x00014FBC File Offset: 0x000131BC
		public CustomConstantAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E72 RID: 11890
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x04002E73 RID: 11891
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
