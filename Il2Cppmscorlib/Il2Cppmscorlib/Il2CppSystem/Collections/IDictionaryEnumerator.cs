using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x020004BD RID: 1213
	public class IDictionaryEnumerator : Il2CppObjectBase
	{
		// Token: 0x06004A69 RID: 19049 RVA: 0x00158000 File Offset: 0x00156200
		// Note: this type is marked as 'beforefieldinit'.
		static IDictionaryEnumerator()
		{
			Il2CppClassPointerStore<IDictionaryEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "IDictionaryEnumerator");
			IDictionaryEnumerator.NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDictionaryEnumerator>.NativeClassPtr, 100674114);
			IDictionaryEnumerator.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDictionaryEnumerator>.NativeClassPtr, 100674115);
			IDictionaryEnumerator.NativeMethodInfoPtr_get_Entry_Public_Abstract_Virtual_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDictionaryEnumerator>.NativeClassPtr, 100674116);
		}

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x06004A6A RID: 19050 RVA: 0x00158064 File Offset: 0x00156264
		public unsafe virtual Object Key
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDictionaryEnumerator.NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x06004A6B RID: 19051 RVA: 0x001580B0 File Offset: 0x001562B0
		public unsafe virtual Object Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDictionaryEnumerator.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x06004A6C RID: 19052 RVA: 0x001580FC File Offset: 0x001562FC
		public unsafe virtual DictionaryEntry Entry
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDictionaryEnumerator.NativeMethodInfoPtr_get_Entry_Public_Abstract_Virtual_New_get_DictionaryEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DictionaryEntry(intPtr);
			}
		}

		// Token: 0x06004A6D RID: 19053 RVA: 0x0001B4B1 File Offset: 0x000196B1
		public IDictionaryEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003CFA RID: 15610
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x04003CFB RID: 15611
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x04003CFC RID: 15612
		private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Abstract_Virtual_New_get_DictionaryEntry_0;
	}
}
