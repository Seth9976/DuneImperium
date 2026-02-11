using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Properties.Internal;

namespace Unity.Properties
{
	// Token: 0x02000038 RID: 56
	public static class PropertyContainer
	{
		// Token: 0x060001B6 RID: 438 RVA: 0x00002E9F File Offset: 0x0000109F
		public static void Accept<TContainer>(IPropertyBagVisitor visitor, TContainer container, [Optional] VisitParameters parameters)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002EAC File Offset: 0x000010AC
		public static void Accept<TContainer>(IPropertyBagVisitor visitor, ref TContainer container, [Optional] VisitParameters parameters)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000082C0 File Offset: 0x000064C0
		public static bool TryAccept<TContainer>(IPropertyBagVisitor visitor, ref TContainer container, [Optional] VisitParameters parameters)
		{
			VisitReturnCode visitReturnCode;
			return PropertyContainer.TryAccept<TContainer>(visitor, ref container, out visitReturnCode, parameters);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000082DC File Offset: 0x000064DC
		public static bool TryAccept<TContainer>(IPropertyBagVisitor visitor, ref TContainer container, out VisitReturnCode returnCode, [Optional] VisitParameters parameters)
		{
			bool flag = !TypeTraits<TContainer>.IsContainer;
			bool flag2;
			if (flag)
			{
				returnCode = VisitReturnCode.InvalidContainerType;
				flag2 = false;
			}
			else
			{
				bool canBeNull = TypeTraits<TContainer>.CanBeNull;
				if (canBeNull)
				{
					bool flag3 = EqualityComparer<TContainer>.Default.Equals(container, default(TContainer));
					if (flag3)
					{
						returnCode = VisitReturnCode.NullContainer;
						return false;
					}
				}
				bool flag4 = !TypeTraits<TContainer>.IsValueType && Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<TContainer>()) != container.GetType();
				if (flag4)
				{
					bool flag5 = !TypeTraits.IsContainer(container.GetType());
					if (flag5)
					{
						returnCode = VisitReturnCode.InvalidContainerType;
						return false;
					}
					IPropertyBag propertyBag = Unity.Properties.Internal.PropertyBagStore.GetPropertyBag(container.GetType());
					bool flag6 = propertyBag == null;
					if (flag6)
					{
						returnCode = VisitReturnCode.MissingPropertyBag;
						return false;
					}
					Object @object = container;
					propertyBag.Accept(visitor, ref @object);
					container = @object.Cast<TContainer>();
				}
				else
				{
					IPropertyBag<TContainer> propertyBag2 = Unity.Properties.Internal.PropertyBagStore.GetPropertyBag<TContainer>();
					bool flag7 = propertyBag2 == null;
					if (flag7)
					{
						returnCode = VisitReturnCode.MissingPropertyBag;
						return false;
					}
					PropertyBag.AcceptWithSpecializedVisitor<TContainer>(propertyBag2, visitor, ref container);
				}
				returnCode = VisitReturnCode.Ok;
				flag2 = true;
			}
			return flag2;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002EB9 File Offset: 0x000010B9
		public static TValue GetValue<TContainer, TValue>(TContainer container, string name)
		{
			return PropertyContainer.GetValue<TContainer, TValue>(ref container, name);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002EC3 File Offset: 0x000010C3
		public static TValue GetValue<TContainer, TValue>(ref TContainer container, string name)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002ED0 File Offset: 0x000010D0
		public static bool TryGetValue<TContainer, TValue>(TContainer container, string name, out TValue value)
		{
			return PropertyContainer.TryGetValue<TContainer, TValue>(ref container, name, out value);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002EDB File Offset: 0x000010DB
		public static bool TryGetValue<TContainer, TValue>(ref TContainer container, string name, out TValue value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002EE8 File Offset: 0x000010E8
		public static bool IsPathValid<TContainer>(TContainer container, string path)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002EF5 File Offset: 0x000010F5
		public static bool IsPathValid<TContainer>(ref TContainer container, string path)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002F02 File Offset: 0x00001102
		public static void SetValue<TContainer, TValue>(TContainer container, string name, TValue value)
		{
			PropertyContainer.SetValue<TContainer, TValue>(ref container, name, value);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002F0E File Offset: 0x0000110E
		public static void SetValue<TContainer, TValue>(ref TContainer container, string name, TValue value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002F1B File Offset: 0x0000111B
		public static bool TrySetValue<TContainer, TValue>(TContainer container, string name, TValue value)
		{
			return PropertyContainer.TrySetValue<TContainer, TValue>(ref container, name, value);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002F26 File Offset: 0x00001126
		public static bool TrySetValue<TContainer, TValue>(ref TContainer container, string name, TValue value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x020000AF RID: 175
		public class GetPropertyVisitor : PathVisitor
		{
			// Token: 0x020000B4 RID: 180
			[Serializable]
			public sealed class <>c
			{
			}
		}

		// Token: 0x020000B0 RID: 176
		public class ValueAtPathVisitor : PathVisitor
		{
			// Token: 0x020000B5 RID: 181
			[Serializable]
			public sealed class <>c
			{
			}
		}

		// Token: 0x020000B1 RID: 177
		public class ExistsAtPathVisitor : PathVisitor
		{
			// Token: 0x020000B6 RID: 182
			[Serializable]
			public sealed class <>c
			{
			}
		}
	}
}
