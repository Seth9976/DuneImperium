using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200006D RID: 109
	public class InstanceMethodCallExpression : MethodCallExpression
	{
		// Token: 0x060005D9 RID: 1497 RVA: 0x0002C418 File Offset: 0x0002A618
		// Note: this type is marked as 'beforefieldinit'.
		static InstanceMethodCallExpression()
		{
			Il2CppClassPointerStore<InstanceMethodCallExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "InstanceMethodCallExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceMethodCallExpression>.NativeClassPtr);
			InstanceMethodCallExpression.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceMethodCallExpression>.NativeClassPtr, "_instance");
			InstanceMethodCallExpression.NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceMethodCallExpression>.NativeClassPtr, 100664537);
			InstanceMethodCallExpression.NativeMethodInfoPtr_GetInstance_Internal_Virtual_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceMethodCallExpression>.NativeClassPtr, 100664538);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0002C484 File Offset: 0x0002A684
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1014283, RefRangeEnd = 1014293, XrefRangeStart = 1014277, XrefRangeEnd = 1014283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstanceMethodCallExpression(MethodInfo method, Expression instance)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstanceMethodCallExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceMethodCallExpression.NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0002C4E4 File Offset: 0x0002A6E4
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression GetInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InstanceMethodCallExpression.NativeMethodInfoPtr_GetInstance_Internal_Virtual_Expression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00003675 File Offset: 0x00001875
		public InstanceMethodCallExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x0002C530 File Offset: 0x0002A730
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x0000367E File Offset: 0x0000187E
		public unsafe Expression _instance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceMethodCallExpression.NativeFieldInfoPtr__instance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceMethodCallExpression.NativeFieldInfoPtr__instance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeFieldInfoPtr__instance;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_Expression_0;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_GetInstance_Internal_Virtual_Expression_0;
	}
}
